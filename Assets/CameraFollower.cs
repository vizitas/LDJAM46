using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform player;
    private Transform CameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        CameraTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraTransform.position = new Vector3(player.position.x, CameraTransform.position.y, player.position.z);
    }
}
