// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""7950d413-887b-4981-9af7-fd730118dcf5"",
            ""actions"": [
                {
                    ""name"": ""Finger1Pos"",
                    ""type"": ""Value"",
                    ""id"": ""1895c3ec-d0f6-48e5-8ac3-2236745b915b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Finger2Pos"",
                    ""type"": ""Value"",
                    ""id"": ""98d7e49a-7dde-4311-9687-80b6ceeda190"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Finger1Touch"",
                    ""type"": ""Button"",
                    ""id"": ""efe81f78-c391-473b-a181-85116f80e47b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Finger2Touch"",
                    ""type"": ""Button"",
                    ""id"": ""8b774fc1-c197-4e20-9c66-eadf47326375"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""595d511d-2140-4f49-95b6-41285be8e14d"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Finger1Pos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d776417-e129-47e2-be1d-d9a6cca4db31"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Finger1Pos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46e8ff8d-fda8-4e9b-a582-a94d78568c3b"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Finger2Pos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a754454-2f87-4e84-9896-4698ba051628"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Finger1Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00109904-740a-49fe-8d27-6918ac34be92"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Finger2Touch"",
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
        m_Player_Finger1Pos = m_Player.FindAction("Finger1Pos", throwIfNotFound: true);
        m_Player_Finger2Pos = m_Player.FindAction("Finger2Pos", throwIfNotFound: true);
        m_Player_Finger1Touch = m_Player.FindAction("Finger1Touch", throwIfNotFound: true);
        m_Player_Finger2Touch = m_Player.FindAction("Finger2Touch", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Finger1Pos;
    private readonly InputAction m_Player_Finger2Pos;
    private readonly InputAction m_Player_Finger1Touch;
    private readonly InputAction m_Player_Finger2Touch;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Finger1Pos => m_Wrapper.m_Player_Finger1Pos;
        public InputAction @Finger2Pos => m_Wrapper.m_Player_Finger2Pos;
        public InputAction @Finger1Touch => m_Wrapper.m_Player_Finger1Touch;
        public InputAction @Finger2Touch => m_Wrapper.m_Player_Finger2Touch;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Finger1Pos.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFinger1Pos;
                @Finger1Pos.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFinger1Pos;
                @Finger1Pos.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFinger1Pos;
                @Finger2Pos.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFinger2Pos;
                @Finger2Pos.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFinger2Pos;
                @Finger2Pos.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFinger2Pos;
                @Finger1Touch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFinger1Touch;
                @Finger1Touch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFinger1Touch;
                @Finger1Touch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFinger1Touch;
                @Finger2Touch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFinger2Touch;
                @Finger2Touch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFinger2Touch;
                @Finger2Touch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFinger2Touch;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Finger1Pos.started += instance.OnFinger1Pos;
                @Finger1Pos.performed += instance.OnFinger1Pos;
                @Finger1Pos.canceled += instance.OnFinger1Pos;
                @Finger2Pos.started += instance.OnFinger2Pos;
                @Finger2Pos.performed += instance.OnFinger2Pos;
                @Finger2Pos.canceled += instance.OnFinger2Pos;
                @Finger1Touch.started += instance.OnFinger1Touch;
                @Finger1Touch.performed += instance.OnFinger1Touch;
                @Finger1Touch.canceled += instance.OnFinger1Touch;
                @Finger2Touch.started += instance.OnFinger2Touch;
                @Finger2Touch.performed += instance.OnFinger2Touch;
                @Finger2Touch.canceled += instance.OnFinger2Touch;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnFinger1Pos(InputAction.CallbackContext context);
        void OnFinger2Pos(InputAction.CallbackContext context);
        void OnFinger1Touch(InputAction.CallbackContext context);
        void OnFinger2Touch(InputAction.CallbackContext context);
    }
}
