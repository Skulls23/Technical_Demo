using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float moveSpeed = 5;
    public float rotationSpeed = 0.5f;

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
        {
            animator.StopPlayback();
            animator.SetInteger("forward", 2);
            transform.Translate(0, 0, 1 * moveSpeed * Time.deltaTime);
        }

        //WALK
        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetInteger("forward", 1);
            transform.Translate(0, 0, 1 * (moveSpeed/2) * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetInteger("forward", 0);
        }


        ////////////
        //  TURN  //
        ////////////


        if (Input.GetKey(KeyCode.A))
        {

            animator.SetInteger("turn", 1);
            transform.Rotate(0.0f, Input.GetAxis("Horizontal") * rotationSpeed, 0.0f);
        }


        if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("turn", 2);
            transform.Rotate(0.0f, Input.GetAxis("Horizontal") * rotationSpeed, 0.0f);
        }

        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            animator.SetInteger("turn", 0);
        }


        /////////////
        //  BLOCK  //
        /////////////


        if (Input.GetKey(KeyCode.S) && !(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A)      ||
                                         Input.GetKey(KeyCode.D) || Input.GetKeyUp(KeyCode.Space)))
        {
            animator.SetInteger("forward", -1);
            transform.Translate(0, 0, -1 * (moveSpeed / 2) * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetInteger("forward", 0);
        }


        ////////////
        //  JUMP  //
        ////////////


            if (Input.GetButton("Jump"))
        {
            transform.Translate(0, Input.GetAxis("Jump") * moveSpeed * Time.deltaTime, 0);
        }

    }
}