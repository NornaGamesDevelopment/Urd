using System;
using UnityEngine;
using Urd.Popup;
using Urd.Services;
using Urd.Services.Navigation;
using Urd.Utils;

namespace Urd.View.Popup
{
    public class PopupBodyView : MonoBehaviour
    {
        public IPopupView PopupView { get; private set; }
        public PopupModel PopupModel => PopupView?.PopupModel;
        
        [field: SerializeField]
        public Transform Container { get; private set; }

        public void SetPopupView(IPopupView popupView)
        {
            PopupView = popupView;

            popupView.OnClickOnClose += Close;
        }

        public void Open()
        {
            OnBeginOpen();
        }
        
        protected virtual void OnBeginOpen()
        {
            // TODO: The opening animation
            StaticServiceLocator.Get<IClockService>().AddDelayCall(0.1f, OnIdle);
        }

        protected virtual void OnIdle()
        {
            PopupModel.ChangeStatus(NavigableStatus.Idle);
        }
        
        public void Close()
        {
            if (!PopupModel.IsClosingOrDestroyed)
            {
                StaticServiceLocator.Get<INavigationService>().Close(PopupModel);
                OnBeginClose();
            }
        }
        
        public virtual void OnBeginClose()
        {
            // TODO  close Animation
            StaticServiceLocator.Get<IClockService>().AddDelayCall(0.1f, OnClose);
        }

        protected virtual void OnClose()
        {
            PopupModel.ChangeStatus(NavigableStatus.Closed);
        }

        private void OnDestroy()
        {
            if (PopupView != null)
            {
                PopupView.OnClickOnClose -= Close;
            }
        }
    }
}