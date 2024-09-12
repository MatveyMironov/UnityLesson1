using UnityEngine;

public class PlayerMovement
{
    public void Move(Rigidbody rigidbody, Vector2 horizontalDirection, float movementSpeed)
    {
        Vector3 movement = rigidbody.rotation * new Vector3(horizontalDirection.x, 0, horizontalDirection.y);
        if(rigidbody.velocity.magnitude < movementSpeed)
        {
            rigidbody.velocity += movement;
        }
    }

    public void Rotate(Rigidbody rigidbody, float rotationAmount)
    {
        rigidbody.transform.Rotate(Vector3.up, rotationAmount);
    }

    public void Jump(Rigidbody rigidbody, float jumpForce)
    {
        Vector3 jump = Vector3.up * jumpForce;
        rigidbody.AddForce(jump, ForceMode.Impulse);
    }
}
