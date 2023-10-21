
using UnityEngine;

public class ClickAudioaneble : MonoBehaviour
{
    [SerializeField] AudioSource source;
    void OnMouseDown()
    {
        source.enabled = !source.enabled;
    }
}
