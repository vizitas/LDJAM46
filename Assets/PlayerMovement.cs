using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;

    CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            characterController.Move(new Vector3(speed, 0,0));
        }

        if (Input.GetKey(KeyCode.S))
        {
            characterController.Move(new Vector3(-1*speed, 0,0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            characterController.Move(new Vector3(0, 0, speed));
        }

        if (Input.GetKey(KeyCode.D))
        {
            characterController.Move(new Vector3(0, 0, -1 * speed));
        }
    }
}
