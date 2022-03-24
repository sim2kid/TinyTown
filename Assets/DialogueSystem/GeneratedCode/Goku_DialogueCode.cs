using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Goku_DialogueCode : DialogueCode, IDialogueCode
    {
        public Goku_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 647a4bcf-abf4-4d47-82e8-2d27f1025626 //
int r = UnityEngine.Random.Range(1,5);


        public void Start()
        {
            // Setup //
            conditionChecks.Add("Goku_111a60fa10cc4f7e874d77cad0250957",Goku_111a60fa10cc4f7e874d77cad0250957);
            conditionChecks.Add("Goku_b892ba9d01484bd5afed61ecac851a79",Goku_b892ba9d01484bd5afed61ecac851a79);
            conditionChecks.Add("Goku_1728faab2bce4a0980f2ce7818469fb0",Goku_1728faab2bce4a0980f2ce7818469fb0);
            conditionChecks.Add("Goku_b0a84eb75c41459bb24f75d1dce59311",Goku_b0a84eb75c41459bb24f75d1dce59311);

        }

        // Dialogue Checks //


        // Condition Checks //
        // Condition From Node: 111a60fa-10cc-4f7e-874d-77cad0250957 //
        public bool Goku_111a60fa10cc4f7e874d77cad0250957() {
            return (r == 1);
        }
        // Condition From Node: b892ba9d-0148-4bd5-afed-61ecac851a79 //
        public bool Goku_b892ba9d01484bd5afed61ecac851a79() {
            return (r == 3);
        }
        // Condition From Node: 1728faab-2bce-4a09-80f2-ce7818469fb0 //
        public bool Goku_1728faab2bce4a0980f2ce7818469fb0() {
            return (r == 4);
        }
        // Condition From Node: b0a84eb7-5c41-459b-b24f-75d1dce59311 //
        public bool Goku_b0a84eb75c41459bb24f75d1dce59311() {
            return (r == 2);
        }


        // Event Functions //

    }
}
