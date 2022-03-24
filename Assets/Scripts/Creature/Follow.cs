using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : IState
{
    public IState NextState { get; private set; } = null;

    private CreatureController creature;
    private Transform player;

    public Follow(CreatureController creature)
    {
        this.creature = creature;
        player = Player.PlayerController.current.transform;
    }

    public void Begin()
    {
        creature.agent.SetDestination(player.position);
        creature.agent.isStopped = false;
        Console.Log("Now Follow");
    }

    

    public void Update()
    {
        float playerDis = Vector3.Distance(creature.transform.position, player.position);
        if (playerDis < 1f)
        {
            creature.agent.isStopped = true;

            // Sit at random when nearby
            if (Random.Range(0f, 100f) < 1f)
            {
                NextState = new Sit(creature);
            }
        }
        else 
        {
            creature.agent.isStopped = false;
        }
    }

    public void End()
    {
        creature.agent.isStopped = true;
    }
}
