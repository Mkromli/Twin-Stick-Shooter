//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""8bf5fa6d-277d-44c2-83b0-8238210454d3"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""ad9aa74b-df25-427c-94ce-fe125a143c19"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""83024a72-0cc1-4587-b0f4-6e095f14c75c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""1f86476a-5909-4736-937b-3edff43e8d78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""0fdcb661-21d6-40bc-95b1-1960cd753af5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Value"",
                    ""id"": ""4d5db273-3b92-43f6-97c5-4b625275e01b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""575c65c0-2db7-489d-b07b-b9b1b07f26a9"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4543eeaf-eeec-4e61-b9b9-3dcef3d3bddc"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d461770-eef2-45f1-8b40-5f59d1ff23bd"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93ca4eba-1942-4fd4-964d-c08e6f9d3bad"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0ff9a07-669d-471c-a199-c7ab82b6c966"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovement_Rotate = m_PlayerMovement.FindAction("Rotate", throwIfNotFound: true);
        m_PlayerMovement_Dash = m_PlayerMovement.FindAction("Dash", throwIfNotFound: true);
        m_PlayerMovement_Restart = m_PlayerMovement.FindAction("Restart", throwIfNotFound: true);
        m_PlayerMovement_Shoot = m_PlayerMovement.FindAction("Shoot", throwIfNotFound: true);
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

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Movement;
    private readonly InputAction m_PlayerMovement_Rotate;
    private readonly InputAction m_PlayerMovement_Dash;
    private readonly InputAction m_PlayerMovement_Restart;
    private readonly InputAction m_PlayerMovement_Shoot;
    public struct PlayerMovementActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputAction @Rotate => m_Wrapper.m_PlayerMovement_Rotate;
        public InputAction @Dash => m_Wrapper.m_PlayerMovement_Dash;
        public InputAction @Restart => m_Wrapper.m_PlayerMovement_Restart;
        public InputAction @Shoot => m_Wrapper.m_PlayerMovement_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Rotate.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnRotate;
                @Dash.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnDash;
                @Restart.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnRestart;
                @Shoot.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);
    public interface IPlayerMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}