//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.1
//     from Assets/UrdPackage/Runtime/Game/Scripts/Character/MainCharacters/Input/CharacterInputMoveset.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @CharacterInputMoveset: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CharacterInputMoveset()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CharacterInputMoveset"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""de9a815e-a7d5-4ec3-9785-9ba02ed76050"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""Button"",
                    ""id"": ""4b522def-47c3-45c7-9cac-9fa09f41df76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""VerticalMovement"",
                    ""type"": ""Value"",
                    ""id"": ""33ebc836-8cb4-4024-b5ee-56f40408e32b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""DodgeSkill"",
                    ""type"": ""Button"",
                    ""id"": ""16ecae63-a809-479c-b985-645682116723"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AttackButton"",
                    ""type"": ""Button"",
                    ""id"": ""ffdaf5a0-cb85-4a00-b643-cad710dd9d8e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""78e1d9c4-0e3c-4a11-bd9a-afc17fd0b130"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GamePadMovement"",
                    ""type"": ""Value"",
                    ""id"": ""102ae8b9-dea8-4e27-a589-2b392e382b33"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GamePadAim"",
                    ""type"": ""Value"",
                    ""id"": ""8bd87d38-52a9-45e4-9606-73752aa14955"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""InteractButton"",
                    ""type"": ""Button"",
                    ""id"": ""b55d9e4b-cfc4-4289-ac23-615b08679598"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""HorizontalAxis"",
                    ""id"": ""777e769c-4fdf-4478-aad1-026d79111062"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""449f531e-4d5b-4ad1-8475-69f097bdfeb1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""f54917cb-03c7-452b-81cc-4e3c08b5bcc2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""2e6c0e8e-64f4-46be-a4e1-eb0af0d28d8d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""44865f40-4ee8-4210-96f6-108320b48af1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""VerticalAxis"",
                    ""id"": ""419f62ef-39b6-4567-b21e-ad704b8f3ad8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""27e1fa06-ee68-48a2-b1fc-e873c697f33c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""11ad6608-5005-44cc-825d-b3fed2ebb7cd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f99b228c-f5dd-4288-90ee-25778a4922e4"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""36809468-d6b0-4929-91b4-9fc23db62dda"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5cd0c8de-0e88-49d8-9631-7a59a0303071"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeSkill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fbef1ab-8685-4dbe-a226-c763723d2ad7"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeSkill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""966a5507-dd53-43b5-9cab-b181c5b28ef5"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14e6c86a-8ca6-48ab-89a9-4a62a23be57e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""GamePadMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a531c1ef-f341-4149-a89c-a70f3785d527"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone,NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""GamePadAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d89a7a6-e35d-41dd-86f4-ea418c544159"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InteractButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72d67897-7acc-4595-bfae-4f0de5fe096f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""a834127f-ab55-4c12-851b-5de110fbf8ec"",
            ""actions"": [
                {
                    ""name"": ""DialogBox"",
                    ""type"": ""Button"",
                    ""id"": ""4eb50f64-7e91-4952-b7b3-90d36f484816"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""976fe291-afc6-4bbc-a1e7-62008f911689"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogBox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68020ac9-6a5c-47c1-9768-b16a80695e15"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogBox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d0f553b-ac85-459c-8c67-9924222b5333"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogBox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_HorizontalMovement = m_Character.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_Character_VerticalMovement = m_Character.FindAction("VerticalMovement", throwIfNotFound: true);
        m_Character_DodgeSkill = m_Character.FindAction("DodgeSkill", throwIfNotFound: true);
        m_Character_AttackButton = m_Character.FindAction("AttackButton", throwIfNotFound: true);
        m_Character_MousePosition = m_Character.FindAction("MousePosition", throwIfNotFound: true);
        m_Character_GamePadMovement = m_Character.FindAction("GamePadMovement", throwIfNotFound: true);
        m_Character_GamePadAim = m_Character.FindAction("GamePadAim", throwIfNotFound: true);
        m_Character_InteractButton = m_Character.FindAction("InteractButton", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_DialogBox = m_UI.FindAction("DialogBox", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Character
    private readonly InputActionMap m_Character;
    private List<ICharacterActions> m_CharacterActionsCallbackInterfaces = new List<ICharacterActions>();
    private readonly InputAction m_Character_HorizontalMovement;
    private readonly InputAction m_Character_VerticalMovement;
    private readonly InputAction m_Character_DodgeSkill;
    private readonly InputAction m_Character_AttackButton;
    private readonly InputAction m_Character_MousePosition;
    private readonly InputAction m_Character_GamePadMovement;
    private readonly InputAction m_Character_GamePadAim;
    private readonly InputAction m_Character_InteractButton;
    public struct CharacterActions
    {
        private @CharacterInputMoveset m_Wrapper;
        public CharacterActions(@CharacterInputMoveset wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_Character_HorizontalMovement;
        public InputAction @VerticalMovement => m_Wrapper.m_Character_VerticalMovement;
        public InputAction @DodgeSkill => m_Wrapper.m_Character_DodgeSkill;
        public InputAction @AttackButton => m_Wrapper.m_Character_AttackButton;
        public InputAction @MousePosition => m_Wrapper.m_Character_MousePosition;
        public InputAction @GamePadMovement => m_Wrapper.m_Character_GamePadMovement;
        public InputAction @GamePadAim => m_Wrapper.m_Character_GamePadAim;
        public InputAction @InteractButton => m_Wrapper.m_Character_InteractButton;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void AddCallbacks(ICharacterActions instance)
        {
            if (instance == null || m_Wrapper.m_CharacterActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Add(instance);
            @HorizontalMovement.started += instance.OnHorizontalMovement;
            @HorizontalMovement.performed += instance.OnHorizontalMovement;
            @HorizontalMovement.canceled += instance.OnHorizontalMovement;
            @VerticalMovement.started += instance.OnVerticalMovement;
            @VerticalMovement.performed += instance.OnVerticalMovement;
            @VerticalMovement.canceled += instance.OnVerticalMovement;
            @DodgeSkill.started += instance.OnDodgeSkill;
            @DodgeSkill.performed += instance.OnDodgeSkill;
            @DodgeSkill.canceled += instance.OnDodgeSkill;
            @AttackButton.started += instance.OnAttackButton;
            @AttackButton.performed += instance.OnAttackButton;
            @AttackButton.canceled += instance.OnAttackButton;
            @MousePosition.started += instance.OnMousePosition;
            @MousePosition.performed += instance.OnMousePosition;
            @MousePosition.canceled += instance.OnMousePosition;
            @GamePadMovement.started += instance.OnGamePadMovement;
            @GamePadMovement.performed += instance.OnGamePadMovement;
            @GamePadMovement.canceled += instance.OnGamePadMovement;
            @GamePadAim.started += instance.OnGamePadAim;
            @GamePadAim.performed += instance.OnGamePadAim;
            @GamePadAim.canceled += instance.OnGamePadAim;
            @InteractButton.started += instance.OnInteractButton;
            @InteractButton.performed += instance.OnInteractButton;
            @InteractButton.canceled += instance.OnInteractButton;
        }

        private void UnregisterCallbacks(ICharacterActions instance)
        {
            @HorizontalMovement.started -= instance.OnHorizontalMovement;
            @HorizontalMovement.performed -= instance.OnHorizontalMovement;
            @HorizontalMovement.canceled -= instance.OnHorizontalMovement;
            @VerticalMovement.started -= instance.OnVerticalMovement;
            @VerticalMovement.performed -= instance.OnVerticalMovement;
            @VerticalMovement.canceled -= instance.OnVerticalMovement;
            @DodgeSkill.started -= instance.OnDodgeSkill;
            @DodgeSkill.performed -= instance.OnDodgeSkill;
            @DodgeSkill.canceled -= instance.OnDodgeSkill;
            @AttackButton.started -= instance.OnAttackButton;
            @AttackButton.performed -= instance.OnAttackButton;
            @AttackButton.canceled -= instance.OnAttackButton;
            @MousePosition.started -= instance.OnMousePosition;
            @MousePosition.performed -= instance.OnMousePosition;
            @MousePosition.canceled -= instance.OnMousePosition;
            @GamePadMovement.started -= instance.OnGamePadMovement;
            @GamePadMovement.performed -= instance.OnGamePadMovement;
            @GamePadMovement.canceled -= instance.OnGamePadMovement;
            @GamePadAim.started -= instance.OnGamePadAim;
            @GamePadAim.performed -= instance.OnGamePadAim;
            @GamePadAim.canceled -= instance.OnGamePadAim;
            @InteractButton.started -= instance.OnInteractButton;
            @InteractButton.performed -= instance.OnInteractButton;
            @InteractButton.canceled -= instance.OnInteractButton;
        }

        public void RemoveCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharacterActions instance)
        {
            foreach (var item in m_Wrapper.m_CharacterActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharacterActions @Character => new CharacterActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_DialogBox;
    public struct UIActions
    {
        private @CharacterInputMoveset m_Wrapper;
        public UIActions(@CharacterInputMoveset wrapper) { m_Wrapper = wrapper; }
        public InputAction @DialogBox => m_Wrapper.m_UI_DialogBox;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @DialogBox.started += instance.OnDialogBox;
            @DialogBox.performed += instance.OnDialogBox;
            @DialogBox.canceled += instance.OnDialogBox;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @DialogBox.started -= instance.OnDialogBox;
            @DialogBox.performed -= instance.OnDialogBox;
            @DialogBox.canceled -= instance.OnDialogBox;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface ICharacterActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnVerticalMovement(InputAction.CallbackContext context);
        void OnDodgeSkill(InputAction.CallbackContext context);
        void OnAttackButton(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnGamePadMovement(InputAction.CallbackContext context);
        void OnGamePadAim(InputAction.CallbackContext context);
        void OnInteractButton(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnDialogBox(InputAction.CallbackContext context);
    }
}
