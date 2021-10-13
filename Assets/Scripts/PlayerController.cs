using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Cyclic call
    void FixedUpdate()
    {
        /////////////////
        //  MOVEMENTS  //
        /////////////////

        if (Input.GetButton("Horizontal"))
            transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);

        if (Input.GetButton("Vertical"))
            transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);

        if (Input.GetButton("Jump"))
            transform.Translate(0, Input.GetAxis("Jump") * speed * Time.deltaTime, 0);
    }
}
