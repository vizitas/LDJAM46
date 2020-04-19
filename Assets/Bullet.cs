using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rigidbody;
    public float MinBulletSpeed = 30;
    public float currentSpeed;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentSpeed = rigidbody.velocity.magnitude;
        if ( rigidbody.velocity.magnitude < MinBulletSpeed)
        {
            Destroy(gameObject);
        }
    }
}
