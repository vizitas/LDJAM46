using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bleeding : MonoBehaviour
{
    public GameObject Particles;

    public float CheckInterval = 10;
    public float Probability = 30;

    private bool bleeding = false;
    private float bleedingStart;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Check", CheckInterval, CheckInterval);
    }

    // Update is called once per frame
    void Check()
    {
        if(!bleeding && Random.Range(0, 100) <= Probability)
        {
            bleeding = true;
            Particles.SetActive(true);
            bleedingStart = Time.time;
        }
    }

    private void FixedUpdate()
    {
        if(Time.time - bleedingStart > 10)
        {
            GameStateSingleton.Instance.Death();
        }
    }
}
