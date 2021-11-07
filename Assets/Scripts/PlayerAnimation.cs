using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = transform.GetComponent<Animator>();
    }

    // Cyclic call
    void Update()
    {
        ///////////////
        //  FORWARD  //
        ///////////////

        //RUN
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
            animator.SetInteger("forward", 2);

        //WALK
        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.LeftShift))
            animator.SetInteger("forward", 1);

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
            animator.SetInteger("forward", 0);


        ////////////
        //  TURN  //
        ////////////


        if (Input.GetKey(KeyCode.A))
            animator.SetInteger("turn", 1);


        if (Input.GetKey(KeyCode.D))
            animator.SetInteger("turn", 2);

        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
            animator.SetInteger("turn", 0);


        ////////////////
        //  BACKWARD  //
        ////////////////


        if (Input.GetKey(KeyCode.S))
            animator.SetInteger("forward", -1);


        ////////////
        //  JUMP  //
        ////////////


        if (Input.GetKeyDown(KeyCode.Space) && !(Input.GetKey(KeyCode.Mouse0) && animator.GetBool("shield")))
            animator.Play("Jump");


        //////////////
        //  ATTACK  //
        //////////////


        if (Input.GetKey(KeyCode.Mouse0) && animator.GetInteger("turn") == 0 && animator.GetInteger("forward") == 0)
            animator.Play("Attack");


        //////////////
        //  SHIELD  //
        //////////////


        if (Input.GetKeyDown(KeyCode.Mouse1) && animator.GetInteger("turn") == 0 && animator.GetInteger("forward") == 0)
            animator.SetBool("shield", true);

        if(Input.GetKeyUp(KeyCode.Mouse1))
            animator.SetBool("shield", false);
    }
}