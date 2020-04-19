using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public bool Dead;

    public PlayerMovement Movement;
    public Animator playerAnimator;
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
        Dead = true;
        playerAnimator.SetBool("Dead", true);
        Movement.enabled = false;
        Invoke("DelayedDeath", 2);
    }

    private void DelayedDeath()
    {
        GameStateSingleton.Instance.Death();
    }
}
