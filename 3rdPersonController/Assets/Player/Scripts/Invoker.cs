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

    public void InvokeMove(Vector2 direction)
    {
        Vector3 speed = new Vector3(direction.x, 0f, direction.y) * _player.MovementSpeed;
        _playerMovement.Move(_player.Rigidbody, speed);
    }

    public void InvokeJump()
    {
        _playerMovement.Jump(_player.Rigidbody, _player.JumpForce);
    }
}
