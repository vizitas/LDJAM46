using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public PlayerMovement Movement;
    // Start is called before the first frame 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            Die();
        }
    }

    public void Die()
    {
        Movement.enabled = false;
        Invoke("DelayedDeath", 3);
    }

    private void DelayedDeath()
    {
        GameStateSingleton.Instance.Death();

    }
}
