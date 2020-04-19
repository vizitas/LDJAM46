using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public bool Dead;

    public AudioSource BulletHit;

    public AudioSource Grunt;

    public PlayerMovement Movement;
    public Animator playerAnimator;
    // Start is called before the first frame 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            BulletHit.Play();
            Die();
        }
    }

    public void Die()
    {
        if (!Dead)
        {
            Grunt.Play();
        }

        Dead = true;
        playerAnimator.SetBool("Dead", true);
        Movement.enabled = false;
        DelayedDeath();
    }

    private void DelayedDeath()
    {
        GameStateSingleton.Instance.Death();
    }
}
