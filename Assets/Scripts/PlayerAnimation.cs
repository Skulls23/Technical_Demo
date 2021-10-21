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


        

    }
}