using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerControllerUpDown : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public float speed = 1;
    public bool showHints = false;
    public GameObject target;

    void Start()
    {
        // if (showHints)
        Destroy(target, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 directioin = Player.instance.hmdTransform.TransformDirection(new Vector3(0, input.axis.x, input.axis.y));
        transform.position += speed * Time.deltaTime * new Vector3(input.axis.x, input.axis.y, 0); // x = left, right, y = up, down, z
    }

    // void ShowTouchPadRighthand()
    // {
    //     Instantiate(target);
    // }
}
