using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StageEvents : MonoBehaviour
{
    public StageType runOnStage;
    public UnityEvent onStageBegin;
    public UnityEvent onStageEnd;

    private StageType lastStage;
    private bool lastActive = false;

    void Update()
    {
        if (lastStage != Stage.Instance.CurrentStage) 
        {
            lastStage = Stage.Instance.CurrentStage;
            Events();
        }        
    }

    private void Events() 
    {
        bool contains = Stage.ContainsStage(runOnStage);
        if (contains && !lastActive)
        {
            lastActive = true;
            onStageBegin.Invoke();
        }
        else if (!contains && lastActive) 
        {
            lastActive = false;
            onStageEnd.Invoke();
        }
    }

}
