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

    public bool bleeding = false;
    private float bleedingStart;

    public int Medkits = 0;

    public float HealingProgress = -1f;

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
            var sources = GetComponents<AudioSource>();

            sources[Random.Range(0, sources.Length - 1)].Play();

            bleeding = true;
            Particles.Play();
            bleedingStart = Time.time;
            HealingProgress = 0;
        }
    }
    public bool healing = false;
    float healingStart;
    private void FixedUpdate()
    {
        if (bleeding && GameStateSingleton.Instance.GameState != GameStateSingleton.GameStates.DEATH)
        {
            if (Time.time - bleedingStart > bleedOutTime)
            {
                GameStateSingleton.Instance.Death();
            }
            if (Medkits > 0 && Input.GetKey(KeyCode.F))
            {
                if (!healing)
                {
                    var sources = GetComponents<AudioSource>();

                    sources[sources.Length - 1].Play();
                    healingStart = Time.time;
                }
                healing = true;
            }
            else
            {
                healing = false;
                var sources = GetComponents<AudioSource>();

                sources[sources.Length - 1].Stop();
            }

            if (healing && Time.time - healingStart > healTime)
            {
                bleeding = false;
                healingStart = -1;
                Particles.Stop();
                Medkits--;
                HealingProgress = -1f;
                healing = false;
                var sources = GetComponents<AudioSource>();
                sources[sources.Length - 1].Stop();
            }

            if (healing)
            {
                HealingProgress = ((Time.time - healingStart) / healTime) * 100;
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
