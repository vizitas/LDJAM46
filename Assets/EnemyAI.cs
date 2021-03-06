﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Collider trigger;
    Firing firing;
    AudioSource audio;
        void Start()
    {
        trigger = GetComponent<Collider>();
        firing = GetComponent<Firing>();
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            firing.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            firing.enabled = false;
            firing.CancelInvoke();
            audio.Stop();
        }
    }
}
