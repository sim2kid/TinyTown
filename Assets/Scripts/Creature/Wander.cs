using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Wander : IState
{
    public IState NextState { get; private set; } = null;

    private CreatureController creature;
    private List<Transform> waypoints;
    private int currentPos;

    public Wander(CreatureController creature, string listName)
    {
        this.creature = creature;
        var allList = GameObject.FindObjectsOfType<WaypointList>();
        waypoints = new List<Transform>();
        waypoints = allList.FirstOrDefault(x => x.ListName.Equals(listName))?.Waypoints;
    }

    public void Begin()
    {
        currentPos = -1;

        // Find closest in list
        float dis = float.MaxValue;
        for (int i = 0; i < waypoints.Count; i++) 
        {
            float d = Vector3.Distance(creature.transform.position, waypoints[i].transform.position);
            if (d < dis) 
            {
                currentPos = i;
                dis = d;
            }
        }

        // if list is empty, goto idle
        if (currentPos == 0)
        {
            NextState = new Idle(creature);
        }
        else 
        {
            creature.agent.SetDestination(waypoints[currentPos].position);
            creature.agent.isStopped = false;
        }
        Console.Log("Now Wander");
    }
    public void Update()
    {
        if (currentPos == -1)
            return;

        if (creature.agent.remainingDistance < 0.5f) 
        {
            currentPos++;
            if(currentPos >= waypoints.Count)
                currentPos = 0;

            creature.agent.SetDestination(waypoints[currentPos].position);
        }

        // return to idle at random.
        if (Random.Range(0f, 100f) < 0.01f) 
        {
            NextState = new Idle(creature);
        }

        // Follow Player On Nearby
        float playerDis = Vector3.Distance(Player.PlayerController.current.transform.position,
            creature.transform.position);
        if (Stage.ContainsStage(StageType.ReturnPet) && playerDis < 5f)
        {
            Stage.Instance.CurrentStage = StageType.PetersonQuestPetEndFindNikoBegin;
            NextState = new Follow(creature);
        }
    }
    public void End()
    {
        creature.agent.isStopped = true;
    }
}