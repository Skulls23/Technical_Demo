using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullRotator : MonoBehaviour
{
    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1 * rotationSpeed * Time.deltaTime, 0);
    }
}
