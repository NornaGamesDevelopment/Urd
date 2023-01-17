using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Urd.Error;
using Urd.Boomerang;
using Urd.Utils;
using Urd.View.Boomerang;

namespace Urd.Services.Navigation
{
    public class NavigationBoomerangManager : INavigationManager
    {
        private const string POPUP_TYPES_CONFIG_PATH = "BoomerangTypesConfig";
        
        private BoomerangTypesConfig _boomerangTypesConfig;
        private Transform _boomerangParent;
        
        private IAssetService _assetService;

        private List<BoomerangBodyView> _boomerangsOpened = new List<BoomerangBodyView>();
            
        public NavigationBoomerangManager()
        {
            _assetService = StaticServiceLocator.Get<IAssetService>();
            LoadParent();
            LoadBoomerangTypesConfig();
        }

        private void LoadParent()
        {
            _boomerangParent = GameObject.FindWithTag(CanvasTagNames.BoomerangCanvas.ToString())?.transform;
            if (_boomerangParent == null)
            {
                var error = new ErrorModel(
                    $"[NavigationBoomerangManager] Error when try to get the boomerang Canvas with Tag {CanvasTagNames.BoomerangCanvas}",
                    ErrorCode.Error_404_Not_Found, UnityWebRequest.Result.DataProcessingError);
                Debug.LogWarning(error.ToString());
            }
        }

        private void LoadBoomerangTypesConfig()
        {
            _boomerangTypesConfig = Resources.Load<BoomerangTypesConfig>(POPUP_TYPES_CONFIG_PATH);
            if (_boomerangTypesConfig == null)
            {
                var error = new ErrorModel(
                    $"[NavigationBoomerangManager] Error when try to load boomerang typs config in path {POPUP_TYPES_CONFIG_PATH}",
                    ErrorCode.Error_404_Not_Found, UnityWebRequest.Result.DataProcessingError);
                Debug.LogWarning(error.ToString());
            }
        }

        public bool CanHandle(INavigable navigable)
        {
            return navigable is BoomerangModel && _boomerangTypesConfig.Contains(navigable);
        }

        public void Open(INavigable navigable, Action<bool> onOpenNavigable)
        {
            var boomerangModel = navigable as BoomerangModel;

            if(!_boomerangTypesConfig.TryGetBoomerangView(boomerangModel, out var boomerangViewPrefab))
            {
                var error = new ErrorModel(
                    $"[NavigationBoomerangManager] Error when try to get the boomerang view from the config, boomerang type {boomerangModel.BoomerangType}",
                    ErrorCode.Error_404_Not_Found, UnityWebRequest.Result.DataProcessingError);
                Debug.LogWarning(error.ToString());
                
                onOpenNavigable?.Invoke(false);
                return;
            }
            
            _assetService.Instantiate(_boomerangTypesConfig.BoomerangBodyPrefab.gameObject, _boomerangParent,
                (boomerangBody) => OnInstantiateBoomerangBody(boomerangBody,boomerangViewPrefab, boomerangModel, onOpenNavigable));

        }

        private void OnInstantiateBoomerangBody(GameObject boomerangBodyGameObject, IBoomerangView boomerangViewPrefab, BoomerangModel boomerangModel,
            Action<bool> onOpenNavigable)
        {
            var boomerangBody = boomerangBodyGameObject.GetComponent<BoomerangBodyView>();
            _assetService.Instantiate(boomerangViewPrefab.GameObject, boomerangBody.Container, (boomerangView) => OnInstantiateBoomerangView(boomerangBody, boomerangView, boomerangModel, onOpenNavigable));
        }

        private void OnInstantiateBoomerangView(BoomerangBodyView boomerangBody, GameObject boomerangViewGameObject,
            BoomerangModel boomerangModel, Action<bool> onOpenNavigable)
        {
            if (boomerangViewGameObject == null)
            {
                var error = new ErrorModel(
                    $"[NavigationBoomerangManager] Error when try to instantiate the boomerang view, boomerang type {boomerangModel.BoomerangType}",
                    ErrorCode.Error_404_Not_Found, UnityWebRequest.Result.DataProcessingError);
                Debug.LogWarning(error.ToString());
                
                onOpenNavigable?.Invoke(false);
                return;
            }
            
            var boomerangView = boomerangViewGameObject.GetComponent<IBoomerangView>();
            HydrateModel(boomerangModel);
            boomerangView.SetBoomerangModel(boomerangModel);
            boomerangBody.SetBoomerangView(boomerangView);
            _boomerangsOpened.Add(boomerangBody);
            onOpenNavigable?.Invoke(true);
            
            boomerangBody.BoomerangModel.ChangeStatus(NavigableStatus.Opening);
            boomerangBody.Open();
        }

        private void HydrateModel(BoomerangModel boomerangModel)
        {
            if (boomerangModel.Duration == 0)
            {
                boomerangModel.SetDuration(_boomerangTypesConfig.BoomerangDefaultDuration);
            }
        }

        public bool CanOpen(INavigable navigable)
        {
            return true;
        }

        public void Close(INavigable navigable, Action<bool> onCloseNavigable)
        {
            var boomerangToClose = _boomerangsOpened.Find(
                boomerangBody => boomerangBody.BoomerangModel.Id == navigable.Id 
                && !boomerangBody.BoomerangModel.IsClosingOrDestroyed);
            if (boomerangToClose == null)
            {
                return;
            }
            
            boomerangToClose.BoomerangModel.ChangeStatus(NavigableStatus.Closing);
            boomerangToClose.BoomerangModel.OnStatusChanged += (statusFrom, statusTo) => OnBoomerangModelToCloseChangeStatus(boomerangToClose, statusFrom, statusTo, onCloseNavigable);
            
            boomerangToClose.Close();
        }

        private void OnBoomerangModelToCloseChangeStatus(BoomerangBodyView boomerangToClose, NavigableStatus statusFrom, NavigableStatus statusTo, Action<bool> onCloseNavigable)
        {
            if (statusTo == NavigableStatus.Closed)
            {
                _boomerangsOpened.Remove(boomerangToClose);
                _assetService.Destroy(boomerangToClose.gameObject);
                onCloseNavigable?.Invoke(true);
            }
        }
    }
}