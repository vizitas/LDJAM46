using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCheckpoint : MonoBehaviour
{
    public GameObject[] CheckPoints;
    
    void Start()
    {
       var checkpoint = PlayerPrefs.GetInt("CheckpointID", 420);
        if(checkpoint!= 420)
        {
            for (int n = 0; n <= checkpoint; n++)
            {
                CheckPoints[checkpoint].SetActive(false);
            }
            gameObject.transform.position = CheckPoints[checkpoint].transform.position;
        }
        GetComponent<Bleeding>().Medkits = PlayerPrefs.GetInt("Medkits", 0);
    }
}
