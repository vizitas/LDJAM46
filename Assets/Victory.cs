using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            PlayerPrefs.SetInt("CheckpointID", 420);
            PlayerPrefs.SetInt("Medkits", 0);
            SceneManager.LoadScene("Victory");
        }
    }
}
