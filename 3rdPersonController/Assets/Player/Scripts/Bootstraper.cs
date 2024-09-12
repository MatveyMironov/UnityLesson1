using UnityEngine;

public class Bootstraper : MonoBehaviour
{
    private Invoker _invoker;

    [SerializeField] private Player player;
    [SerializeField] private InputListener inputListener;

    private void Awake()
    {
        _invoker = new Invoker(player);
        inputListener.Invoker = _invoker;
    }
}
