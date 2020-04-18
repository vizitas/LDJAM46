using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bleeding : MonoBehaviour
{
    public ParticleSystem Particles;

    public float CheckInterval = 10;
    public float Probability = 30;

    public float bleedOutTime = 10f;
    public float healTime = 3f;

    private bool bleeding = false;
    private float bleedingStart;

    public int Medkits = 0;
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
            Particles.Play();
            bleedingStart = Time.time;
        }
    }
    bool healing = false;
    float healingStart;
    private void FixedUpdate()
    {
        if (bleeding)
        {
            if (Time.time - bleedingStart > bleedOutTime)
            {
                GameStateSingleton.Instance.Death();
            }
            if (Medkits > 0 && Input.GetKeyDown(KeyCode.F))
            {
                healingStart = Time.time;
            }
            if (Medkits > 0 && Input.GetKey(KeyCode.F))
            {
                healing = true;
            }
            else
            {
                healing = false;
            }

            if (healing && Time.time - healingStart > healTime)
            {
                bleeding = false;
                Particles.Stop();
                Medkits--;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "medkit")
        {
            Medkits++;
            Destroy(other.gameObject);
        }
    }
}
