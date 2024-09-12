using UnityEngine;
using UnityEngine.InputSystem;

public class InputListener : MonoBehaviour
{
    private PlayerControls _playerControls;
    public Invoker Invoker { get; set; }

    private void Awake()
    {
        _playerControls = new PlayerControls();

        _playerControls.MainActionMap.Move.started += InvokeMove;
        _playerControls.MainActionMap.Move.performed += InvokeMove;
        _playerControls.MainActionMap.Move.canceled += InvokeMove;

        _playerControls.MainActionMap.Jump.started += InvokeJump;
    }

    private void InvokeMove(InputAction.CallbackContext callbackContext)
    {
        Vector2 moveInput = callbackContext.ReadValue<Vector2>();
        Invoker.InvokeMove(moveInput);
    }

    private void InvokeJump(InputAction.CallbackContext callbackContext)
    {
        Invoker.InvokeJump();
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
