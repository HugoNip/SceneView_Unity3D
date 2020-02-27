using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerController : MonoBehaviour
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
    // private CharacterController characterController;

    // private void Start()
    // {
    //     characterController = GetComponent<CharacterController>();
    // }

    // Update is called once per frame
    void Update()
    {
         Vector3 directioin = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
         transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(directioin, Vector3.up);
         // characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(directioin, Vector3.up) - new Vector3(0, 9.81f, 0) * Time.deltaTime);
    }

}
