using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;

    CharacterController characterController;
    Transform playerTransform;
    public Animator playerAnimator;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        playerTransform = GetComponent<Transform>();

    }

    void FixedUpdate()
    {
        float rotation = 0;
        bool forwardBackward = false;
        bool moved = false;
        if (Input.GetKey(KeyCode.W))
        {
            characterController.Move(new Vector3(speed, 0,0));
            rotation = 0;
            moved = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            characterController.Move(new Vector3(-1*speed, 0,0));
            rotation = -180;
            moved = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            characterController.Move(new Vector3(0, 0, speed));
            rotation =  -90;
            moved = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            characterController.Move(new Vector3(0, 0, -1 * speed));
            rotation =  90;
            moved = true;
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            rotation = -45;
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            rotation = 45;
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            rotation = -135;
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            rotation = 135;
        if (moved)
        {
            playerAnimator.SetBool("IsRunning", true);
            playerTransform.rotation = Quaternion.Euler(new Vector3(playerTransform.rotation.eulerAngles.x, rotation, playerTransform.rotation.eulerAngles.z));
        }
        else
        {
            playerAnimator.SetBool("IsRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            GameStateSingleton.Instance.Death();
    }
}
