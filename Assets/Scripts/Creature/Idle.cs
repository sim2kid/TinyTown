using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : IState
{
    public IState NextState { get; private set; } = null;

    private CreatureController creature;
    float timePassed;
    float sitInterval;
    float wanderInteval;

    public Idle(CreatureController creature) 
    {
        this.creature = creature;
    }

    public void Begin()
    {
        NextState = null;
        timePassed = 0;
        sitInterval = Random.Range(5, 15f);
        wanderInteval = Random.Range(10, 30f);
        Console.Log("Now Idle");
    }
    public void Update()
    {
        timePassed += Time.deltaTime;

        // Sit at random
        if (timePassed > sitInterval)
        {
            creature.anime.SetBool("Sitting", true);
        }
        else if(Random.Range(0f,100f) < 0.2f)
        {
            creature.anime.SetTrigger("WiggleButt");
        }
        // Wander interval
        if (timePassed > wanderInteval) 
        {
            NextState = new Wander(creature, "waypoints");
        }
        // Follow Player On Nearby
        float playerDis = Vector3.Distance(Player.PlayerController.current.transform.position,
            creature.transform.position);
        if (Stage.ContainsStage(StageType.PetersonQuestPoopEndPetBegin) && playerDis < 5f) 
        {
            Stage.Instance.CurrentStage = StageType.ReturnPet;
            NextState = new Follow(creature);
        }
    }
    public void End()
    {
        creature.anime.SetBool("Sitting", false);
        creature.anime.ResetTrigger("WiggleButt");
    }
}