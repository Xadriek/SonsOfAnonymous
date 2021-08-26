// GENERATED AUTOMATICALLY FROM 'Assets/MyScript/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""PlayerMain"",
            ""id"": ""1af5d896-c0de-43c0-b2e9-9afab735bd78"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""8baa02b5-1278-4800-b9d8-d41ad33236f8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""look"",
                    ""type"": ""Value"",
                    ""id"": ""09bcf39d-5e34-4065-89b4-1e957ebde2b5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""0aa30c0c-8b0a-452d-86e7-fcda4f819c90"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a9c4c720-61fb-4f4c-9dfa-e83508e25253"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb77756d-4b70-403b-bfaa-52e93e133547"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0170601e-75d0-4e9e-955c-f9f5a12ac36e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMain
        m_PlayerMain = asset.FindActionMap("PlayerMain", throwIfNotFound: true);
        m_PlayerMain_move = m_PlayerMain.FindAction("move", throwIfNotFound: true);
        m_PlayerMain_look = m_PlayerMain.FindAction("look", throwIfNotFound: true);
        m_PlayerMain_Interaction = m_PlayerMain.FindAction("Interaction", throwIfNotFound: true);
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

    // PlayerMain
    private readonly InputActionMap m_PlayerMain;
    private IPlayerMainActions m_PlayerMainActionsCallbackInterface;
    private readonly InputAction m_PlayerMain_move;
    private readonly InputAction m_PlayerMain_look;
    private readonly InputAction m_PlayerMain_Interaction;
    public struct PlayerMainActions
    {
        private @Player m_Wrapper;
        public PlayerMainActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_PlayerMain_move;
        public InputAction @look => m_Wrapper.m_PlayerMain_look;
        public InputAction @Interaction => m_Wrapper.m_PlayerMain_Interaction;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMainActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMainActions instance)
        {
            if (m_Wrapper.m_PlayerMainActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @look.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @look.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @look.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @Interaction.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnInteraction;
            }
            m_Wrapper.m_PlayerMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @look.started += instance.OnLook;
                @look.performed += instance.OnLook;
                @look.canceled += instance.OnLook;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
            }
        }
    }
    public PlayerMainActions @PlayerMain => new PlayerMainActions(this);
    public interface IPlayerMainActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
    }
}
