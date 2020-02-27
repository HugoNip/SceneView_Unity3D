using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ShowingHidingScreens : MonoBehaviour
{
    public SteamVR_Action_Boolean inputLeftShow;
    public SteamVR_Action_Boolean inputRightShow;

    void Update()
    {
        if (inputLeftShow.lastState)
        {
            Show();
        }
        if (inputRightShow.lastState)
        {
            Hide();
        }
    }

    void Show()
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 1;
    }

    void Hide()
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 0;
    }
}
