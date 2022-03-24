using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreatureController : MonoBehaviour
{

    public NavMeshAgent agent;
    public Animator anime;

    public IState currentState;
    bool hasStarted = false;

    Vector3 lastLoc = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        lastLoc = transform.position;
        currentState = new Idle(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.speed != 0)
        {
            float speed = agent.velocity.magnitude;
            anime.SetFloat("Speed", speed / agent.speed);
        }

        if (!hasStarted)
        {
            currentState.Begin();
            hasStarted = true;
        }
        else 
        {
            currentState.Update();
            if (currentState.NextState != null) 
            {
                currentState.End();
                currentState = currentState.NextState;
                hasStarted = false;
            }
        }
    }
}
