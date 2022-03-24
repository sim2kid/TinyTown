using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreatureController : MonoBehaviour
{
    public Vector3 NextDestination;
    public float MinDistance = 0.1f;

    public NavMeshAgent agent;
    public Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        if (NextDestination == Vector3.zero || NextDestination == null) 
        {
            NextDestination = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, NextDestination) < MinDistance) 
        {
        }
    }

    public void StopMovement() 
    {
        
    }
}
