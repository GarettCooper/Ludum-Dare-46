// GENERATED AUTOMATICALLY FROM 'Assets/ControlsSchemes.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControlsSchemes : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlsSchemes()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlsSchemes"",
    ""maps"": [
        {
            ""name"": ""Primary"",
            ""id"": ""0320b4f8-ba2d-4818-9b45-1d8e87fc84c8"",
            ""actions"": [
                {
                    ""name"": ""Horizontal Movement"",
                    ""type"": ""Value"",
                    ""id"": ""4b361d09-f6d5-4139-9327-a5a2ed98b589"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""849e726a-7556-476f-bbb3-5ee0ac59f058"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mute"",
                    ""type"": ""Button"",
                    ""id"": ""d9ff9901-502d-4b8b-ad89-e41d2f62289e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard WASD"",
                    ""id"": ""92a778dc-ed66-4885-8ecd-e8e9a7b2c491"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""508dccfa-e791-4166-a405-7954f2e119af"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Primary Control Scheme"",
                    ""action"": ""Horizontal Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3e203bd7-d429-4cc5-ac21-e9642226ee49"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Primary Control Scheme"",
                    ""action"": ""Horizontal Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Arrows"",
                    ""id"": ""9074f196-ef22-441b-99bb-82ae8b2345a6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""06079eab-9879-427e-ab6e-54c99d813599"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Primary Control Scheme"",
                    ""action"": ""Horizontal Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""04e497bb-b2c1-46ed-bf2d-0b69363c4a2b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Primary Control Scheme"",
                    ""action"": ""Horizontal Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b442fbd4-bc13-421e-a270-27a3d2935d9f"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Primary Control Scheme"",
                    ""action"": ""Horizontal Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a82eac07-c689-482b-8859-56ad037e3b5d"",
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
                    ""id"": ""33a44c78-ec49-4431-9eea-697705f8bb08"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a4cdd38-dfc9-419f-9507-1e14a3a0a834"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mute"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3635e8d3-55d9-43c7-bbb7-dd7858847d27"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mute"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Primary Control Scheme"",
            ""bindingGroup"": ""Primary Control Scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Primary
        m_Primary = asset.FindActionMap("Primary", throwIfNotFound: true);
        m_Primary_HorizontalMovement = m_Primary.FindAction("Horizontal Movement", throwIfNotFound: true);
        m_Primary_Jump = m_Primary.FindAction("Jump", throwIfNotFound: true);
        m_Primary_Mute = m_Primary.FindAction("Mute", throwIfNotFound: true);
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

    // Primary
    private readonly InputActionMap m_Primary;
    private IPrimaryActions m_PrimaryActionsCallbackInterface;
    private readonly InputAction m_Primary_HorizontalMovement;
    private readonly InputAction m_Primary_Jump;
    private readonly InputAction m_Primary_Mute;
    public struct PrimaryActions
    {
        private @ControlsSchemes m_Wrapper;
        public PrimaryActions(@ControlsSchemes wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_Primary_HorizontalMovement;
        public InputAction @Jump => m_Wrapper.m_Primary_Jump;
        public InputAction @Mute => m_Wrapper.m_Primary_Mute;
        public InputActionMap Get() { return m_Wrapper.m_Primary; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PrimaryActions set) { return set.Get(); }
        public void SetCallbacks(IPrimaryActions instance)
        {
            if (m_Wrapper.m_PrimaryActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnHorizontalMovement;
                @Jump.started -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnJump;
                @Mute.started -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMute;
                @Mute.performed -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMute;
                @Mute.canceled -= m_Wrapper.m_PrimaryActionsCallbackInterface.OnMute;
            }
            m_Wrapper.m_PrimaryActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Mute.started += instance.OnMute;
                @Mute.performed += instance.OnMute;
                @Mute.canceled += instance.OnMute;
            }
        }
    }
    public PrimaryActions @Primary => new PrimaryActions(this);
    private int m_PrimaryControlSchemeSchemeIndex = -1;
    public InputControlScheme PrimaryControlSchemeScheme
    {
        get
        {
            if (m_PrimaryControlSchemeSchemeIndex == -1) m_PrimaryControlSchemeSchemeIndex = asset.FindControlSchemeIndex("Primary Control Scheme");
            return asset.controlSchemes[m_PrimaryControlSchemeSchemeIndex];
        }
    }
    public interface IPrimaryActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMute(InputAction.CallbackContext context);
    }
}
