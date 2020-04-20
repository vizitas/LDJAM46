using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artilery : MonoBehaviour
{
    void Start()
    {
        Invoke("explosion", 0.6f);
        Invoke("disable",0.75f);
        Destroy(gameObject, 5);
    }
    private void disable()
    {
        GetComponent<Collider>().enabled = false;
        GetComponent<Light>().enabled = false;
    }

    private void explosion()
    {
        GetComponent<Collider>().enabled = true;
        GetComponent<Light>().enabled = true;
        GetComponent<ParticleSystem>().Play();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var deathController = other.GetComponent<Death>();
            deathController.Die();
        }
    }
}
