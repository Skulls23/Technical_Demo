using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Function to do an action when hitting a collider
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collectibles"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
