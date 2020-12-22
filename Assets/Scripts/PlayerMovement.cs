// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerMovement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerMovement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""Walk"",
            ""id"": ""c2e801ff-41bb-49eb-9afa-9d198800e912"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dfc02928-4507-45d5-ade3-0738ed83a7ef"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector3"",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""265df7b2-48d2-4803-9331-985e9d3c9d59"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d58ba2f5-a5ad-4363-a45a-e603e71c85cc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""53572c08-7208-466b-8c75-30db5d9b32c7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7c297562-0b5c-4317-9770-e80d3e1e18ef"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""74f8da12-fc17-458c-8569-d5b46601506c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""35214f76-3a53-4205-a62d-cb517cc25f92"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e3638911-9398-4efa-920a-e3768f23e9c0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d810d3b7-9aab-4bfd-a328-3c576a12cbc4"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d3c5637c-8a19-4fc5-a380-d7aed55d3ea2"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3453ced1-dd9d-4223-ac9e-498382cb1657"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Action"",
            ""id"": ""9241fe3e-678e-4230-8f66-4725823207d6"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ee491de0-5eb9-444c-8f8c-973689aea699"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""B"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7d1f8b47-5683-4aa7-a7b0-fc898b5620e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4d6b2bef-9615-42a3-9f60-4fa359f947e2"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""531c6c24-1368-41a3-83e5-a1185e0bede7"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Walk
        m_Walk = asset.FindActionMap("Walk", throwIfNotFound: true);
        m_Walk_Movement = m_Walk.FindAction("Movement", throwIfNotFound: true);
        // Action
        m_Action = asset.FindActionMap("Action", throwIfNotFound: true);
        m_Action_A = m_Action.FindAction("A", throwIfNotFound: true);
        m_Action_B = m_Action.FindAction("B", throwIfNotFound: true);
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

    // Walk
    private readonly InputActionMap m_Walk;
    private IWalkActions m_WalkActionsCallbackInterface;
    private readonly InputAction m_Walk_Movement;
    public struct WalkActions
    {
        private @PlayerMovement m_Wrapper;
        public WalkActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Walk_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Walk; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WalkActions set) { return set.Get(); }
        public void SetCallbacks(IWalkActions instance)
        {
            if (m_Wrapper.m_WalkActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_WalkActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public WalkActions @Walk => new WalkActions(this);

    // Action
    private readonly InputActionMap m_Action;
    private IActionActions m_ActionActionsCallbackInterface;
    private readonly InputAction m_Action_A;
    private readonly InputAction m_Action_B;
    public struct ActionActions
    {
        private @PlayerMovement m_Wrapper;
        public ActionActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_Action_A;
        public InputAction @B => m_Wrapper.m_Action_B;
        public InputActionMap Get() { return m_Wrapper.m_Action; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionActions set) { return set.Get(); }
        public void SetCallbacks(IActionActions instance)
        {
            if (m_Wrapper.m_ActionActionsCallbackInterface != null)
            {
                @A.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnB;
            }
            m_Wrapper.m_ActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
            }
        }
    }
    public ActionActions @Action => new ActionActions(this);
    public interface IWalkActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IActionActions
    {
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
    }
}
