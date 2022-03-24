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

    public StageType CurrentStage;

    public Stage() 
    {
        CurrentStage = StageType.PetersonQuestPoopBegin;
    }

    public static bool ContainsStage(StageType groupOfStages) 
    {
        return (int)(Instance.CurrentStage & groupOfStages) != 0;
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
    NikoPoopEnd = 1 << 6
}