using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Test_DialogueCode : DialogueCode, IDialogueCode
    {
        public Test_DialogueCode() 
        {
            Start();
        }


        // Variables //


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Test_2855a85a52094e9686822fa99d987dac_67e8022c3d874c238ede094e0dc01970",Test_2855a85a52094e9686822fa99d987dac_67e8022c3d874c238ede094e0dc01970);

        }

        // Dialogue Checks //
        // From Node: 2855a85a-5209-4e96-8682-2fa99d987dac //
        // Choice: Hello There Cube - 67e8022c-3d87-4c23-8ede-094e0dc01970 //
        public bool Test_2855a85a52094e9686822fa99d987dac_67e8022c3d874c238ede094e0dc01970()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //

    }
}
