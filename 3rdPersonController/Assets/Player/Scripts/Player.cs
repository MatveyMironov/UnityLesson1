using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody Rigidbody { get; private set; }
    [field:SerializeField] public float MovementSpeed { get; private set; }
    [field:SerializeField] public float JumpForce { get; private set; }

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }
}
