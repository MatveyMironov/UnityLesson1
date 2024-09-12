using UnityEngine;

public class Invoker
{
    private PlayerMovement _playerMovement;
    private Player _player;

    public Invoker(Player player)
    {
        _player = player;
        _playerMovement = new PlayerMovement();
    }

    public void InvokeMove(Vector2 horizontalDirection)
    {
        if (_player.IsGrounded)
        {
            _playerMovement.Move(_player.Rigidbody, horizontalDirection, _player.MovementSpeed);
        }
    }

    public void InvokeJump()
    {
        if (_player.IsGrounded)
        {
            _playerMovement.Jump(_player.Rigidbody, _player.JumpForce);
        }
    }

    public void InvokeRotate(float rotationAmount)
    {
        _playerMovement.Rotate(_player.Rigidbody, rotationAmount * _player.RotationSensetivity);
    }
}
