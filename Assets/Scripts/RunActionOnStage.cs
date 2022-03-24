using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RunActionOnStage : MonoBehaviour
{
    public StageType runOnStage;
    public UnityEvent onExecute;

    public void Execute() 
    {
        if (Stage.ContainsStage(runOnStage)) 
        {
            onExecute.Invoke();
        }
    }
}
