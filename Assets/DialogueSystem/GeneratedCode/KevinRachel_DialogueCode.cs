using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class KevinRachel_DialogueCode : DialogueCode, IDialogueCode
    {
        public KevinRachel_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: a584eb34-dc67-4c39-aba2-478ba4756614 //
int r = UnityEngine.Random.Range(0,2);


        public void Start()
        {
            // Setup //
            conditionChecks.Add("KevinRachel_766d4f7949794856996a8ed6ec13fd1c",KevinRachel_766d4f7949794856996a8ed6ec13fd1c);
            eventFunctions.Add("KevinRachel_c79f4ccdbc3445f4ba6ba6ecb6a0692e",KevinRachel_c79f4ccdbc3445f4ba6ba6ecb6a0692e);

        }

        // Dialogue Checks //


        // Condition Checks //
        // Condition From Node: 766d4f79-4979-4856-996a-8ed6ec13fd1c //
        public bool KevinRachel_766d4f7949794856996a8ed6ec13fd1c() {
            return (r % 2 == 0);
        }


        // Event Functions //
        // Event From Node: c79f4ccd-bc34-45f4-ba6b-a6ecb6a0692e //
        public void KevinRachel_c79f4ccdbc3445f4ba6ba6ecb6a0692e() {
r = UnityEngine.Random.Range(0,2);
        }

    }
}
