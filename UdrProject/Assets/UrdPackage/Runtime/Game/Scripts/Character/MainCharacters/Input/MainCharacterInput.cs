using System;
using System.Dynamic;
using MyBox;
using UnityEngine;
using UnityEngine.InputSystem;
using Urd.Services;
using Urd.Utils;

namespace Urd.Character
{
    public class MainCharacterInput : ICharacterInput
    {
        private const string HORIZONTAL_MOVEMENT = "HorizontalMovement";
        private const string VERTICAL_MOVEMENT = "VerticalMovement";
        private const string DODGE_SKILL = "DodgeSkill";

        public Vector2 Movement => _movement;
        public Vector2 _movement;
        public bool IsDodging { get; private set; }

        private IInputService _inputService;
        private CharacterModel _characterModel;
        
        public event Action<Vector2> OnMovementChanged;
        public event Action<bool> OnIsDodgingChanged;

        public MainCharacterInput(CharacterModel characterModel)
        {
            _characterModel = characterModel;

            Init();
        }

        public void Init()
        {
            _inputService = StaticServiceLocator.Get<IInputService>();

            StaticServiceLocator.Get<IClockService>().AddDelayCall(2f, SetInput);
            //SetInput();
        }

        private void SetInput()
        {
            _inputService.SubscribeToActionOnStarted(HORIZONTAL_MOVEMENT, OnHorizontalMovementDown);
            _inputService.SubscribeToActionOnCancel(HORIZONTAL_MOVEMENT, OnHorizontalMovementUp);

            _inputService.SubscribeToActionOnStarted(VERTICAL_MOVEMENT, OnVerticalMovementDown);
            _inputService.SubscribeToActionOnCancel(VERTICAL_MOVEMENT, OnVerticalMovementUp);
            
            _inputService.SubscribeToActionOnPerformed(DODGE_SKILL, OnDodgeSkillDown);
            _inputService.SubscribeToActionOnCancel(DODGE_SKILL, OnDodgeSkillUp);
        }
        
        public void Dispose()
        {
            _inputService.UnsubscribeToActionOnPerformed(HORIZONTAL_MOVEMENT, OnHorizontalMovementDown);
            _inputService.UnsubscribeToActionOnCancel(HORIZONTAL_MOVEMENT, OnHorizontalMovementUp);

            _inputService.UnsubscribeToActionOnPerformed(VERTICAL_MOVEMENT, OnVerticalMovementDown);
            _inputService.UnsubscribeToActionOnCancel(VERTICAL_MOVEMENT, OnVerticalMovementUp);
            
            _inputService.UnsubscribeToActionOnPerformed(DODGE_SKILL, OnDodgeSkillDown);
            _inputService.UnsubscribeToActionOnCancel(DODGE_SKILL, OnDodgeSkillUp);

            OnIsDodgingChanged = null;
            OnMovementChanged = null;
        }

        private void OnHorizontalMovementDown(InputAction.CallbackContext inputAction)
        {
            _movement.x = inputAction.ReadValue<Single>();
            OnMovementChanged?.Invoke(Movement);
            Debug.Log($"OnHorizontalMovementDown:{Movement}");
        }

        private void OnHorizontalMovementUp(InputAction.CallbackContext inputAction)
        {
            _movement.x = inputAction.ReadValue<Single>();
            OnMovementChanged?.Invoke(Movement);
        }

        private void OnVerticalMovementDown(InputAction.CallbackContext inputAction)
        {
            _movement.y = inputAction.ReadValue<Single>();
            OnMovementChanged?.Invoke(Movement);
            Debug.Log($"OnVerticalMovementDown:{Movement}");
        }

        private void OnVerticalMovementUp(InputAction.CallbackContext inputAction)
        {
            _movement.y = inputAction.ReadValue<Single>();
            OnMovementChanged?.Invoke(Movement);
        }
        
        private void OnDodgeSkillDown(InputAction.CallbackContext inputAction)
        {
            IsDodging = true;
            OnIsDodgingChanged?.Invoke(IsDodging);
        }
        private void OnDodgeSkillUp(InputAction.CallbackContext inputAction)
        {
            IsDodging = false;
            OnIsDodgingChanged?.Invoke(IsDodging);
        }
    }
}