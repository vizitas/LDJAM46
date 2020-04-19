using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artilery : MonoBehaviour
{
    void Start()
    {
        Invoke("disable", 0.5f);
        Destroy(gameObject, 5);
    }
    private void disable()
    {
        GetComponent<Collider>().enabled = false;
    }
}
