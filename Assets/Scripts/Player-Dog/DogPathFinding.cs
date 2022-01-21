using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DogPathFinding : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;
    float stopRange = 2f;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Paladin");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, player.transform.position) > stopRange)
            agent.SetDestination(player.transform.position);
        else
            agent.SetDestination(transform.position);
    }
}
