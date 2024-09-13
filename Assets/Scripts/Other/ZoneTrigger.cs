using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneTrigger : MonoBehaviour
{
    [SerializeField] private CanvasGroupFader _infoCanvas;
    private void OnTriggerEnter(Collider other)
    {
        _infoCanvas.FadeInSmooth(true);
    }
    private void OnTriggerExit(Collider other)
    {
        _infoCanvas.FadeInSmooth(false);
    }
}
