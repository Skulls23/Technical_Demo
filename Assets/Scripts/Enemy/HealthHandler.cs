using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHandler : MonoBehaviour
{
    [SerializeField]
    private int health;
    private bool isDead;

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public bool IsDead {get; set;}
}
