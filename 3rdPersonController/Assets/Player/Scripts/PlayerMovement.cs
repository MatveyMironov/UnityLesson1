using UnityEngine;

public class PlayerMovement
{
    public void Move(Rigidbody rigidbody, Vector3 speed)
    {
        rigidbody.velocity = speed;
    }

    public void Rotate(Rigidbody rigidbody)
    {

    }

    public void Jump(Rigidbody rigidbody, float jumpForce)
    {
        Vector3 jump = Vector3.up * jumpForce;
        rigidbody.AddForce(jump, ForceMode.Impulse);
    }
}
