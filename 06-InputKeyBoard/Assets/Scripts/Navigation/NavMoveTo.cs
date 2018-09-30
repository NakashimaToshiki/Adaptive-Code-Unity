using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMoveTo : MonoBehaviour {

    public Transform goal;

    public NavMeshAgent agent;

    void Update()
    {
        agent.destination = goal.position;
    }
}
