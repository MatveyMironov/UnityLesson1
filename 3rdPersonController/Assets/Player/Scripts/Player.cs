using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody Rigidbody { get; private set; }
    [field:SerializeField] public float MovementSpeed { get; private set; }
    [field:SerializeField] public float JumpForce { get; private set; }
    [field:SerializeField] public float RotationSensetivity { get; private set; }

    public bool IsGrounded { get; private set; }

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        CheckIfGrounded();
    }

    private void CheckIfGrounded()
    {
        if(Physics.Raycast(transform.position + Vector3.up, Vector3.down, 1.05f))
        {
            IsGrounded = true;
        }
        else
        {
            IsGrounded = false;
        }
    }
}
