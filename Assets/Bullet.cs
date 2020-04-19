using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rigidbody;
    public float MinBulletSpeed = 30;
    public float currentSpeed;
    public AudioSource audio;
    public float AudioFrequency = 30;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
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
    private void OnCollisionEnter(Collision collision)
    {
        if (Random.Range(0,100)<= AudioFrequency)
        {
            audio.Play();
        }
    }
}
