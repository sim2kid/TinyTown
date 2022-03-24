using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage
{
    private static Stage _instance;
    public static Stage Instance 
    {   
        get 
        {
            if (_instance == null)
            { 
                _instance = new Stage();
            }
            return _instance;
        }
    }

    public int poopPileOne = 14;
    public int poopPileTwo = 31;
    public void PickUpPileOne() 
    {
        poopPileOne--;
        if (poopPileOne == 0) 
        {
            CurrentStage = StageType.PetersonQuestPoopEndPetBegin;
        }
    }
    public void PickUpPileTwo()
    {
        poopPileTwo--;
        if (poopPileTwo == 0) 
        {
            CurrentStage = StageType.NikoPoopEnd;
        }
    }

    public StageType CurrentStage;

    public Stage() 
    {
        CurrentStage = StageType.PetersonQuestPoopBegin;
    }

    public static bool ContainsStage(StageType groupOfStages) 
    {
        return ContainsStage((int)groupOfStages);
    }

    public static bool ContainsStage(int groupOfStages)
    {
        return ((int)Instance.CurrentStage & (int)groupOfStages) != 0;
    }
}

[System.Flags]
public enum StageType
{
    PetersonQuestPoopBegin = 1 << 0,
    PoopPile = 1 << 1,
    PetersonQuestPoopEndPetBegin = 1 << 2,
    ReturnPet = 1 << 3,
    PetersonQuestPetEndFindNikoBegin = 1 << 4,
    NikoPoopCollection = 1 << 5,
    NikoPoopEnd = 1 << 6,
    GameOver = 1 << 7,
}