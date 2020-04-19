using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public ParticleSystem[] Particles;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            foreach(var particle in Particles)
            {
                particle.Play();
            }
            var deathController = other.GetComponent<Death>();
            deathController.Die();
        }
    }
}
