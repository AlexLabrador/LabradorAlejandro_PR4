// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/InputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputAction"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""3dfe5954-3a91-4d79-9568-a0e3484c6016"",
            ""actions"": [
                {
                    ""name"": ""Moverse"",
                    ""type"": ""Value"",
                    ""id"": ""08c64787-ccce-4b95-aacc-4f037e9823cb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Correr"",
                    ""type"": ""Button"",
                    ""id"": ""fb8672e9-5626-4f4b-905e-2a7579496f87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Desp.Lateral.izq"",
                    ""type"": ""Value"",
                    ""id"": ""a3b600ce-37db-474c-8f44-405f97fe4330"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Desp.Lateral.drch"",
                    ""type"": ""Value"",
                    ""id"": ""fdf71c98-0391-41f1-b98f-986a62f4c0b8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d3e6edf1-ca04-4c15-9e18-a982c541fdf3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66665b42-25c6-42f9-aabd-733d861086b3"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Correr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b788d20-046a-4074-8edd-4b057fb22689"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Desp.Lateral.izq"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58d064b1-4ea0-429f-86e5-2584ca79575b"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Desp.Lateral.drch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""camera"",
            ""id"": ""7479671f-84bf-42f8-9e5f-7062413855a9"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Value"",
                    ""id"": ""9e64b678-e1d5-4110-b8ae-1446c170f495"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""feecc655-8b24-46d2-969d-9ad0fe656b95"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Moverse = m_Player.FindAction("Moverse", throwIfNotFound: true);
        m_Player_Correr = m_Player.FindAction("Correr", throwIfNotFound: true);
        m_Player_DespLateralizq = m_Player.FindAction("Desp.Lateral.izq", throwIfNotFound: true);
        m_Player_DespLateraldrch = m_Player.FindAction("Desp.Lateral.drch", throwIfNotFound: true);
        // camera
        m_camera = asset.FindActionMap("camera", throwIfNotFound: true);
        m_camera_Newaction = m_camera.FindAction("New action", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Moverse;
    private readonly InputAction m_Player_Correr;
    private readonly InputAction m_Player_DespLateralizq;
    private readonly InputAction m_Player_DespLateraldrch;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moverse => m_Wrapper.m_Player_Moverse;
        public InputAction @Correr => m_Wrapper.m_Player_Correr;
        public InputAction @DespLateralizq => m_Wrapper.m_Player_DespLateralizq;
        public InputAction @DespLateraldrch => m_Wrapper.m_Player_DespLateraldrch;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Moverse.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoverse;
                @Moverse.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoverse;
                @Moverse.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoverse;
                @Correr.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCorrer;
                @Correr.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCorrer;
                @Correr.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCorrer;
                @DespLateralizq.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDespLateralizq;
                @DespLateralizq.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDespLateralizq;
                @DespLateralizq.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDespLateralizq;
                @DespLateraldrch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDespLateraldrch;
                @DespLateraldrch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDespLateraldrch;
                @DespLateraldrch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDespLateraldrch;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Moverse.started += instance.OnMoverse;
                @Moverse.performed += instance.OnMoverse;
                @Moverse.canceled += instance.OnMoverse;
                @Correr.started += instance.OnCorrer;
                @Correr.performed += instance.OnCorrer;
                @Correr.canceled += instance.OnCorrer;
                @DespLateralizq.started += instance.OnDespLateralizq;
                @DespLateralizq.performed += instance.OnDespLateralizq;
                @DespLateralizq.canceled += instance.OnDespLateralizq;
                @DespLateraldrch.started += instance.OnDespLateraldrch;
                @DespLateraldrch.performed += instance.OnDespLateraldrch;
                @DespLateraldrch.canceled += instance.OnDespLateraldrch;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // camera
    private readonly InputActionMap m_camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_camera_Newaction;
    public struct CameraActions
    {
        private @InputActions m_Wrapper;
        public CameraActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_camera_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public CameraActions @camera => new CameraActions(this);
    public interface IPlayerActions
    {
        void OnMoverse(InputAction.CallbackContext context);
        void OnCorrer(InputAction.CallbackContext context);
        void OnDespLateralizq(InputAction.CallbackContext context);
        void OnDespLateraldrch(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
