using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputListener : MonoBehaviour
{
    private PlayerControls _playerControls;
    public Invoker Invoker { get; set; }

    private Vector2 _moveInput;
    private bool _controlsActive;

    public static Action<bool> OnControlsToggled;

    private void Awake()
    {
        _playerControls = new PlayerControls();

        _playerControls.MainActionMap.ToggleControls.performed += OnToggleControls;

        _playerControls.MainActionMap.Move.started += OnMoveInput;
        _playerControls.MainActionMap.Move.performed += OnMoveInput;
        _playerControls.MainActionMap.Move.canceled += OnMoveInput;

        _playerControls.MainActionMap.Jump.started += OnJumpInput;

        _playerControls.MainActionMap.Rotate.started += OnRotateInput;
        _playerControls.MainActionMap.Rotate.performed += OnRotateInput;
        _playerControls.MainActionMap.Rotate.canceled += OnRotateInput;
    }

    private void OnToggleControls(InputAction.CallbackContext callbackContext)
    {
        _controlsActive = !_controlsActive;
        OnControlsToggled?.Invoke(_controlsActive);
    }

    private void OnMoveInput(InputAction.CallbackContext callbackContext)
    {
        if (!_controlsActive) return;
        _moveInput = callbackContext.ReadValue<Vector2>();
    }

    private void OnJumpInput(InputAction.CallbackContext callbackContext)
    {
        if (!_controlsActive) return;
        Invoker.InvokeJump();
    }

    private void OnRotateInput(InputAction.CallbackContext callbackContext)
    {
        if (!_controlsActive) return;
        Vector2 rotateInput = callbackContext.ReadValue<Vector2>();

        Invoker.InvokeRotate(rotateInput.x);
    }

    private void Update()
    {
        Invoker.InvokeMove(_moveInput);
    }

    private void OnEnable()
    {
        _playerControls.MainActionMap.Enable();
    }

    private void OnDisable()
    {
        _playerControls.MainActionMap.Disable();
    }
}
