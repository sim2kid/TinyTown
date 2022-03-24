using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sit : IState
{
    public IState NextState { get; private set; } = null;

    private CreatureController creature;
    private Transform player;

    public Sit(CreatureController creature)
    {
        this.creature = creature;
        player = Player.PlayerController.current.transform;
    }

    public void Begin()
    {
        creature.agent.SetDestination(player.position);
        creature.anime.SetBool("Sitting", true);
        Console.Log("Now Sit");
    }

    public void Update()
    {
        float playerDis = Vector3.Distance(creature.transform.position, player.position);
        if (playerDis > 3f)
        {
            NextState = new Follow(creature);
        }
    }

    public void End()
    {
        creature.anime.SetBool("Sitting", false);
    }
}
