using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ModelNameDisplayScreen : MonoBehaviour
{
    public SteamVR_Action_Boolean inputLeftShow;
    public SteamVR_Action_Boolean inputRightHide;

    // Start is called before the first frame update
    void Start()
    {
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputLeftShow.lastState || Input.GetKeyDown(KeyCode.A))
        {
            Show();

        }

        if (inputRightHide.lastState || Input.GetKeyDown(KeyCode.B))
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
