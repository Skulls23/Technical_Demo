using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private static int DAMAGE_DONE = 10;


    public void DoDamage(RaycastHit rch)
    {
        Debug.Log(rch.collider.gameObject.tag);
        if (rch.collider.gameObject.CompareTag("Enemy"))
        {
            animator = rch.collider.gameObject.GetComponent<Animator>();

            rch.collider.gameObject.GetComponent<ArcherController>().Health -= DAMAGE_DONE;

            if (rch.collider.gameObject.GetComponent<ArcherController>().Health <= 0)
            {
                animator.SetBool("isAlive", false);
                transform.gameObject.GetComponent<PlayerController>().ArcherKilled();
            }
            else
                animator.SetTrigger("hit");
        }

    }
}
