using UnityEngine;

public class CanvasText : MonoBehaviour
{
    [SerializeField] private GameObject text;

    private void ShowText(bool show)
    {
        if (show)
        {
            text.SetActive(false);
        }
        else
        {
            text.SetActive(true);
        }
    }

    private void OnEnable()
    {
        InputListener.OnControlsToggled += ShowText;
    }
}
