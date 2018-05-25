using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour {
    public Transform goal;
    NavMeshAgent agent;

    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();
        //agent.destination = goal.position;
    }

    //Update is called once per frame
    void Update () {
        agent.SetDestination(goal.position);

    }
}
