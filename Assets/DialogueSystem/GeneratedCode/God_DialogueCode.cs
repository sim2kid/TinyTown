using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class God_DialogueCode : DialogueCode, IDialogueCode
    {
        public God_DialogueCode() 
        {
            Start();
        }


        // Variables //


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("God_0a7f7cd456c04708b208144c4ad7a893_cc77326603f74f5bae9e8df6c014d18f",God_0a7f7cd456c04708b208144c4ad7a893_cc77326603f74f5bae9e8df6c014d18f);
            dialogueChecks.Add("God_0a7f7cd456c04708b208144c4ad7a893_9d6a0b6054b9483d8017489af309f5e2",God_0a7f7cd456c04708b208144c4ad7a893_9d6a0b6054b9483d8017489af309f5e2);
            eventFunctions.Add("God_f304de48825d4b85b8cccd2b68840934",God_f304de48825d4b85b8cccd2b68840934);

        }

        // Dialogue Checks //
        // From Node: 0a7f7cd4-56c0-4708-b208-144c4ad7a893 //
        // Choice: Stay Here - cc773266-03f7-4f5b-ae9e-8df6c014d18f //
        public bool God_0a7f7cd456c04708b208144c4ad7a893_cc77326603f74f5bae9e8df6c014d18f()
        {
            return (true);
        }
        // From Node: 0a7f7cd4-56c0-4708-b208-144c4ad7a893 //
        // Choice: Restart The World - 9d6a0b60-54b9-483d-8017-489af309f5e2 //
        public bool God_0a7f7cd456c04708b208144c4ad7a893_9d6a0b6054b9483d8017489af309f5e2()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //
        // Event From Node: f304de48-825d-4b85-b8cc-cd2b68840934 //
        public void God_f304de48825d4b85b8cccd2b68840934() {
UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

    }
}
