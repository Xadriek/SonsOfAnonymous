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
                    ""name"": ""lower"",
                    ""type"": ""Button"",
                    ""id"": ""cb2d1c36-47fb-4ffe-829c-7cb5772c6fce"",
                    ""expectedControlType"": ""Button"",
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
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""05c3daca-cc8f-4c7d-aade-b52de9eab6db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""4b302b74-d546-46f9-b280-d7c80188e933"",
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
                    ""id"": ""8b932fe7-b242-4f26-b914-e2f0dbfa5c81"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4ea88aa-5857-4cd9-9da5-c76975e931ad"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lower"",
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
                    ""id"": ""5cb10241-b788-4fea-b5d5-357e3d7040d5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba670600-a27e-4338-b4c1-d4916b91d903"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Pause/Resume"",
            ""id"": ""2563cecf-b107-4bec-8f22-43a1bd77336e"",
            ""actions"": [
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""39c3721d-f93d-4cf5-8871-dda19e46e0df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""778c7d72-0a54-41e4-8568-eacea4045142"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""30889f6f-f95e-48f6-ba32-5f11e897b592"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c08bdbd-487d-4383-801b-93b4f4beb772"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
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
        m_PlayerMain_lower = m_PlayerMain.FindAction("lower", throwIfNotFound: true);
        m_PlayerMain_look = m_PlayerMain.FindAction("look", throwIfNotFound: true);
        m_PlayerMain_Jump = m_PlayerMain.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMain_Pause = m_PlayerMain.FindAction("Pause", throwIfNotFound: true);
        // Pause/Resume
        m_PauseResume = asset.FindActionMap("Pause/Resume", throwIfNotFound: true);
        m_PauseResume_Resume = m_PauseResume.FindAction("Resume", throwIfNotFound: true);
        m_PauseResume_Exit = m_PauseResume.FindAction("Exit", throwIfNotFound: true);
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
    private readonly InputAction m_PlayerMain_lower;
    private readonly InputAction m_PlayerMain_look;
    private readonly InputAction m_PlayerMain_Jump;
    private readonly InputAction m_PlayerMain_Pause;
    public struct PlayerMainActions
    {
        private @Player m_Wrapper;
        public PlayerMainActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_PlayerMain_move;
        public InputAction @lower => m_Wrapper.m_PlayerMain_lower;
        public InputAction @look => m_Wrapper.m_PlayerMain_look;
        public InputAction @Jump => m_Wrapper.m_PlayerMain_Jump;
        public InputAction @Pause => m_Wrapper.m_PlayerMain_Pause;
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
                @lower.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLower;
                @lower.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLower;
                @lower.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLower;
                @look.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @look.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @look.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @Pause.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @lower.started += instance.OnLower;
                @lower.performed += instance.OnLower;
                @lower.canceled += instance.OnLower;
                @look.started += instance.OnLook;
                @look.performed += instance.OnLook;
                @look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerMainActions @PlayerMain => new PlayerMainActions(this);

    // Pause/Resume
    private readonly InputActionMap m_PauseResume;
    private IPauseResumeActions m_PauseResumeActionsCallbackInterface;
    private readonly InputAction m_PauseResume_Resume;
    private readonly InputAction m_PauseResume_Exit;
    public struct PauseResumeActions
    {
        private @Player m_Wrapper;
        public PauseResumeActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Resume => m_Wrapper.m_PauseResume_Resume;
        public InputAction @Exit => m_Wrapper.m_PauseResume_Exit;
        public InputActionMap Get() { return m_Wrapper.m_PauseResume; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseResumeActions set) { return set.Get(); }
        public void SetCallbacks(IPauseResumeActions instance)
        {
            if (m_Wrapper.m_PauseResumeActionsCallbackInterface != null)
            {
                @Resume.started -= m_Wrapper.m_PauseResumeActionsCallbackInterface.OnResume;
                @Resume.performed -= m_Wrapper.m_PauseResumeActionsCallbackInterface.OnResume;
                @Resume.canceled -= m_Wrapper.m_PauseResumeActionsCallbackInterface.OnResume;
                @Exit.started -= m_Wrapper.m_PauseResumeActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_PauseResumeActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_PauseResumeActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_PauseResumeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Resume.started += instance.OnResume;
                @Resume.performed += instance.OnResume;
                @Resume.canceled += instance.OnResume;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public PauseResumeActions @PauseResume => new PauseResumeActions(this);
    public interface IPlayerMainActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLower(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IPauseResumeActions
    {
        void OnResume(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
}
