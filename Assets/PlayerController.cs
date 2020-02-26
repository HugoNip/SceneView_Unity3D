using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerController : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public float speed = 1;
    private CharacterController characterController;
    private Vector3 direction;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     Vector3 directioin = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
    //     transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(directioin, Vector3.up);
    //     characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(directioin, Vector3.up) - new Vector3(0, 9.81f, 0) * Time.deltaTime);
    //     characterController.height = Mathf.Max(characterController.radius, Player.instance.hmdTransform.localPosition.y);
    //     characterController.center = new Vector3(Player.instance.hmdTransform.localPosition.x, (characterController.height / 2), Player.instance.hmdTransform.localPosition.z);
    // }

    void Update()
    {
         direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
    }

    // void FixedUpdate()
    // {
    //     characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up) - new Vector3(0, 9.81f, 0) * Time.deltaTime);
    // }
}
