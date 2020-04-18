using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform player;
    private Transform CameraTransform;
    public float xOffset = 0;
    public float zOffset = 0;
    // Start is called before the first frame update
    void Start()
    {
        CameraTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraTransform.position = new Vector3(player.position.x + xOffset, CameraTransform.position.y, player.position.z + zOffset);
    }
}
