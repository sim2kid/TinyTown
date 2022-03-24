using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Niko_DialogueCode : DialogueCode, IDialogueCode
    {
        public Niko_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 569403a5-3f87-43b2-8541-7f318f7a9866 //
int before = (int)StageType.PetersonQuestPoopBegin + (int)StageType.PoopPile +
(int)StageType.PetersonQuestPoopEndPetBegin + (int)StageType.ReturnPet;
int poopLeft => Stage.Instance.poopPileTwo;


        public void Start()
        {
            // Setup //
            conditionChecks.Add("Niko_af91f758331243acbc9fcca874bf0823",Niko_af91f758331243acbc9fcca874bf0823);
            dialogueChecks.Add("Niko_955e124cfd0a4a11be8109c12cb545ff_91193f27f53f431ba560c125d8070295",Niko_955e124cfd0a4a11be8109c12cb545ff_91193f27f53f431ba560c125d8070295);
            dialogueChecks.Add("Niko_d679bf7f553b4efda564d1ac7bd60e49_3c0445a8f0c5442780f4bff6ae4f2cb6",Niko_d679bf7f553b4efda564d1ac7bd60e49_3c0445a8f0c5442780f4bff6ae4f2cb6);
            dialogueChecks.Add("Niko_efb80f3f54484b69a25e97186ffea945_7de729c252d44833b1f434656b5fbb4d",Niko_efb80f3f54484b69a25e97186ffea945_7de729c252d44833b1f434656b5fbb4d);
            dialogueChecks.Add("Niko_efb80f3f54484b69a25e97186ffea945_fd2e483811fc4029a2a846df5482a88a",Niko_efb80f3f54484b69a25e97186ffea945_fd2e483811fc4029a2a846df5482a88a);
            dialogueChecks.Add("Niko_e6f67504b233489c90ed532e8f24e479_40131c3786ca41db871b69abd90f0c4d",Niko_e6f67504b233489c90ed532e8f24e479_40131c3786ca41db871b69abd90f0c4d);
            conditionChecks.Add("Niko_d2456d8162a3432f9d5283db42d714f8",Niko_d2456d8162a3432f9d5283db42d714f8);
            conditionChecks.Add("Niko_62e6d247e3f04fb9bd8c0e2d5d25be5b",Niko_62e6d247e3f04fb9bd8c0e2d5d25be5b);
            conditionChecks.Add("Niko_34f47f3fbc5b416f8c476c32191dcd75",Niko_34f47f3fbc5b416f8c476c32191dcd75);
            conditionChecks.Add("Niko_1c9fbce3ea5749a1895699e632175cdf",Niko_1c9fbce3ea5749a1895699e632175cdf);
            dialogueChecks.Add("Niko_258dce24f59647ca9fe8b36e02359ef8_f0a415446a4249d8b5c2f1aedf44aa47",Niko_258dce24f59647ca9fe8b36e02359ef8_f0a415446a4249d8b5c2f1aedf44aa47);
            dialogueChecks.Add("Niko_c976a6e9aacb4668bdabfc7fe431b013_5d75a07d432f46a1bed3ba2a79a6e720",Niko_c976a6e9aacb4668bdabfc7fe431b013_5d75a07d432f46a1bed3ba2a79a6e720);
            eventFunctions.Add("Niko_e259fb9e364e49a4913d0124342225f8",Niko_e259fb9e364e49a4913d0124342225f8);
            eventFunctions.Add("Niko_83fa1aa442e949ba88ccd0e356f3c1cc",Niko_83fa1aa442e949ba88ccd0e356f3c1cc);

        }

        // Dialogue Checks //
        // From Node: 955e124c-fd0a-4a11-be81-09c12cb545ff //
        // Choice: Um.. Niko? - 91193f27-f53f-431b-a560-c125d8070295 //
        public bool Niko_955e124cfd0a4a11be8109c12cb545ff_91193f27f53f431ba560c125d8070295()
        {
            return (true);
        }
        // From Node: d679bf7f-553b-4efd-a564-d1ac7bd60e49 //
        // Choice: Ms Peterson told me to bring this little guy to you. - 3c0445a8-f0c5-4427-80f4-bff6ae4f2cb6 //
        public bool Niko_d679bf7f553b4efda564d1ac7bd60e49_3c0445a8f0c5442780f4bff6ae4f2cb6()
        {
            return (true);
        }
        // From Node: efb80f3f-5448-4b69-a25e-97186ffea945 //
        // Choice: Sure thing! - 7de729c2-52d4-4833-b1f4-34656b5fbb4d //
        public bool Niko_efb80f3f54484b69a25e97186ffea945_7de729c252d44833b1f434656b5fbb4d()
        {
            return (true);
        }
        // From Node: efb80f3f-5448-4b69-a25e-97186ffea945 //
        // Choice: No Way! - fd2e4838-11fc-4029-a2a8-46df5482a88a //
        public bool Niko_efb80f3f54484b69a25e97186ffea945_fd2e483811fc4029a2a846df5482a88a()
        {
            return (true);
        }
        // From Node: e6f67504-b233-489c-90ed-532e8f24e479 //
        // Choice: Is this enough? - 40131c37-86ca-41db-871b-69abd90f0c4d //
        public bool Niko_e6f67504b233489c90ed532e8f24e479_40131c3786ca41db871b69abd90f0c4d()
        {
            return (true);
        }
        // From Node: 258dce24-f596-47ca-9fe8-b36e02359ef8 //
        // Choice: Yeah, what is it? - f0a41544-6a42-49d8-b5c2-f1aedf44aa47 //
        public bool Niko_258dce24f59647ca9fe8b36e02359ef8_f0a415446a4249d8b5c2f1aedf44aa47()
        {
            return (true);
        }
        // From Node: c976a6e9-aacb-4668-bdab-fc7fe431b013 //
        // Choice: I'm on it! - 5d75a07d-432f-46a1-bed3-ba2a79a6e720 //
        public bool Niko_c976a6e9aacb4668bdabfc7fe431b013_5d75a07d432f46a1bed3ba2a79a6e720()
        {
            return (true);
        }


        // Condition Checks //
        // Condition From Node: af91f758-3312-43ac-bc9f-cca874bf0823 //
        public bool Niko_af91f758331243acbc9fcca874bf0823() {
            return (Stage.ContainsStage(before));
        }
        // Condition From Node: d2456d81-62a3-432f-9d52-83db42d714f8 //
        public bool Niko_d2456d8162a3432f9d5283db42d714f8() {
            return (poopLeft > 0);
        }
        // Condition From Node: 62e6d247-e3f0-4fb9-bd8c-0e2d5d25be5b //
        public bool Niko_62e6d247e3f04fb9bd8c0e2d5d25be5b() {
            return (Stage.ContainsStage(StageType.PetersonQuestPetEndFindNikoBegin));
        }
        // Condition From Node: 34f47f3f-bc5b-416f-8c47-6c32191dcd75 //
        public bool Niko_34f47f3fbc5b416f8c476c32191dcd75() {
            return (Stage.ContainsStage(StageType.NikoPoopCollection));
        }
        // Condition From Node: 1c9fbce3-ea57-49a1-8956-99e632175cdf //
        public bool Niko_1c9fbce3ea5749a1895699e632175cdf() {
            return (Stage.ContainsStage(StageType.NikoPoopEnd));
        }


        // Event Functions //
        // Event From Node: e259fb9e-364e-49a4-913d-0124342225f8 //
        public void Niko_e259fb9e364e49a4913d0124342225f8() {
Stage.Instance.CurrentStage = StageType.NikoPoopCollection;
        }
        // Event From Node: 83fa1aa4-42e9-49ba-88cc-d0e356f3c1cc //
        public void Niko_83fa1aa442e949ba88ccd0e356f3c1cc() {
Stage.Instance.CurrentStage = StageType.GameOver;
        }

    }
}
