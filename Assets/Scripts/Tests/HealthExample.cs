using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthExample : MonoBehaviour
{
    [SerializeField] private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Corruption
        if (Input.GetKeyUp(KeyCode.I))
        {
            player.GetComponent<HealthManager>().AddCorruptedHealth();
        }

        //Damage
        if (Input.GetKeyUp(KeyCode.O))
        {
            player.GetComponent<HealthManager>().TakeDamage();
        }

        //Heal
        if (Input.GetKeyUp(KeyCode.P))
        {
            player.GetComponent<HealthManager>().Heal(3);
        }
    }
}
