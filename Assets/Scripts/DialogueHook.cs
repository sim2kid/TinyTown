using DialogueSystem;
using DialogueSystem.Demo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueHook : MonoBehaviour
{
    DialogueManager dm;

    public UnityEvent OnConvoStart;
    public UnityEvent OnConvoEnd;

    void Start()
    {
        dm = GetComponent<DialogueManager>();
        if (dm == null) 
        {
            Console.LogError($"DialogueManager is missing on {name}. The Dialogue Hook will be deleted.");
            Destroy(this);
        }
    }

    public void StartConvo() 
    {
        DialogueController dc =  FindObjectOfType<DialogueController>();
        if(dc == null)
            return;

        OnConvoStart.Invoke();
        dc.StartConversation(dm, OnConvoEnd);
    }
}
