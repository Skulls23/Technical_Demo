using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float moveSpeed = 5;
    public float rotationSpeed = 0.5f;

    // Cyclic call
    void FixedUpdate()
    {
        ///////////////
        //  FORWARD  //
        ///////////////

        //RUN
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
            transform.Translate(0, 0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);

        //WALK
        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.LeftShift))
            transform.Translate(0, 0, Input.GetAxis("Vertical") * (moveSpeed/2) * Time.deltaTime);


        ////////////
        //  TURN  //
        ////////////


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            transform.Rotate(0.0f, Input.GetAxis("Horizontal") * rotationSpeed, 0.0f);


        ////////////////
        //  BACKWARD  //
        ////////////////


        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, 0, Input.GetAxis("Vertical") * (moveSpeed / 2) * Time.deltaTime);


        ////////////
        //  JUMP  //
        ////////////


        if (Input.GetButton("Jump"))
            transform.Translate(0, Input.GetAxis("Jump") * moveSpeed * Time.deltaTime, 0);

    }
}