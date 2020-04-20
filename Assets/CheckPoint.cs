using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public int CheckpointID = 0;
    public Bleeding player;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("CheckpointID", CheckpointID);
            PlayerPrefs.SetInt("Medkits", player.Medkits);
        }
    }
}
