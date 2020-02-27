using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PointerShowHide : MonoBehaviour
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
        if (inputLeftShow.lastState || Input.GetKeyDown(KeyCode.X))
        {
            Show();

        }

        if (inputRightHide.lastState || Input.GetKeyDown(KeyCode.Y))
        {
            Hide();
        }
    }

    void Show()
    {
        // gameObject.SetActive(true);
        gameObject.GetComponent<Renderer>().enabled = true;
    }

    void Hide()
    {
        // gameObject.SetActive(false);
        gameObject.GetComponent<Renderer>().enabled = false;
    }
}
