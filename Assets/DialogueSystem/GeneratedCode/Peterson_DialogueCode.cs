using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Peterson_DialogueCode : DialogueCode, IDialogueCode
    {
        public Peterson_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 5460fe25-1bc8-452b-8779-409c72a0e7b0 //
int pileOne => Stage.Instance.poopPileOne;
int pileTwo => Stage.Instance.poopPileTwo;


        public void Start()
        {
            // Setup //
            conditionChecks.Add("Peterson_766d4f7949794856996a8ed6ec13fd1c",Peterson_766d4f7949794856996a8ed6ec13fd1c);
            conditionChecks.Add("Peterson_a0974ed008c24504babdefd689ee7747",Peterson_a0974ed008c24504babdefd689ee7747);
            dialogueChecks.Add("Peterson_9a9ffe5b55924078a37e0a9678958ce4_a5bd768407de493a95ad07b36f87717b",Peterson_9a9ffe5b55924078a37e0a9678958ce4_a5bd768407de493a95ad07b36f87717b);
            conditionChecks.Add("Peterson_11756253877745e98b60769200b7d095",Peterson_11756253877745e98b60769200b7d095);
            eventFunctions.Add("Peterson_bcedffc0fdc348fb93a36ae6867d6292",Peterson_bcedffc0fdc348fb93a36ae6867d6292);
            eventFunctions.Add("Peterson_67815e7f39ab4e138655ebc27c93ba97",Peterson_67815e7f39ab4e138655ebc27c93ba97);
            eventFunctions.Add("Peterson_c44846d03b174190a96dd5fc52b7581d",Peterson_c44846d03b174190a96dd5fc52b7581d);
            conditionChecks.Add("Peterson_a3712b133ac841f68fd73e3210fbceba",Peterson_a3712b133ac841f68fd73e3210fbceba);
            conditionChecks.Add("Peterson_7901871262554f619febde329cead64b",Peterson_7901871262554f619febde329cead64b);
            eventFunctions.Add("Peterson_80d8ae35917844259e23ad013f9f0377",Peterson_80d8ae35917844259e23ad013f9f0377);
            eventFunctions.Add("Peterson_e62c7570f9e04bd99eb472ea6abab000",Peterson_e62c7570f9e04bd99eb472ea6abab000);
            eventFunctions.Add("Peterson_d270dbc28cbb405e84ec719fa8c36ff3",Peterson_d270dbc28cbb405e84ec719fa8c36ff3);
            dialogueChecks.Add("Peterson_d302f0c847714cf697da7951267a4eb2_40b3895c879c4a02998d8aae82f8f01d",Peterson_d302f0c847714cf697da7951267a4eb2_40b3895c879c4a02998d8aae82f8f01d);
            dialogueChecks.Add("Peterson_d302f0c847714cf697da7951267a4eb2_47faccce725b40dda270ec2c9af7e54b",Peterson_d302f0c847714cf697da7951267a4eb2_47faccce725b40dda270ec2c9af7e54b);
            dialogueChecks.Add("Peterson_6e9ab8e1dce24fcb844f03fa931b53e3_b6e99962d574438bb183b40014fd58a5",Peterson_6e9ab8e1dce24fcb844f03fa931b53e3_b6e99962d574438bb183b40014fd58a5);
            eventFunctions.Add("Peterson_824caa5119a840b18998d8a62db5d164",Peterson_824caa5119a840b18998d8a62db5d164);
            dialogueChecks.Add("Peterson_db0ef3e6662a41888cefd98a4301607a_974d4b747c0041319a8d4d030b958d3e",Peterson_db0ef3e6662a41888cefd98a4301607a_974d4b747c0041319a8d4d030b958d3e);
            dialogueChecks.Add("Peterson_dd83465853fb46d0880ad04636733336_7c723311f356405bb4bf9d684956b4ac",Peterson_dd83465853fb46d0880ad04636733336_7c723311f356405bb4bf9d684956b4ac);
            dialogueChecks.Add("Peterson_edbd696d481242a6921eed9564edccbc_4221e644a2d7487db8a440836e69c589",Peterson_edbd696d481242a6921eed9564edccbc_4221e644a2d7487db8a440836e69c589);
            dialogueChecks.Add("Peterson_edbd696d481242a6921eed9564edccbc_e64912f67d9a4911aaa562b9f1d5d807",Peterson_edbd696d481242a6921eed9564edccbc_e64912f67d9a4911aaa562b9f1d5d807);
            eventFunctions.Add("Peterson_104ba15a5f924928ab836dc95b040ef0",Peterson_104ba15a5f924928ab836dc95b040ef0);
            dialogueChecks.Add("Peterson_7abdb489950d455792713ccfd1a9e959_e45cd6c56b6a4815874d003c4f98dd36",Peterson_7abdb489950d455792713ccfd1a9e959_e45cd6c56b6a4815874d003c4f98dd36);
            dialogueChecks.Add("Peterson_7abdb489950d455792713ccfd1a9e959_5eba6cc76f0244a1acbcaf4a04360239",Peterson_7abdb489950d455792713ccfd1a9e959_5eba6cc76f0244a1acbcaf4a04360239);
            dialogueChecks.Add("Peterson_6adce4b61d68482d971658feab87a93f_f8d2d2a95e59427b92baa351e2ebfd48",Peterson_6adce4b61d68482d971658feab87a93f_f8d2d2a95e59427b92baa351e2ebfd48);
            dialogueChecks.Add("Peterson_40c089d81344421eb2ac2ff4e70667f7_ca84e5ecd4414ff7b67d189d3cbe5ed1",Peterson_40c089d81344421eb2ac2ff4e70667f7_ca84e5ecd4414ff7b67d189d3cbe5ed1);
            dialogueChecks.Add("Peterson_cb9d79f53b6842f5ac21fccdf73207dd_21646ea929c04f2cb38b7b5ea27fe63e",Peterson_cb9d79f53b6842f5ac21fccdf73207dd_21646ea929c04f2cb38b7b5ea27fe63e);
            dialogueChecks.Add("Peterson_cb9d79f53b6842f5ac21fccdf73207dd_8733c1cd8f5a4f1695be1786eb25cb74",Peterson_cb9d79f53b6842f5ac21fccdf73207dd_8733c1cd8f5a4f1695be1786eb25cb74);
            dialogueChecks.Add("Peterson_39b7b714a01046b1ada1df11c83499c5_3f2730875b1b40ae93efa2ecf33aae0f",Peterson_39b7b714a01046b1ada1df11c83499c5_3f2730875b1b40ae93efa2ecf33aae0f);

        }

        // Dialogue Checks //
        // From Node: 9a9ffe5b-5592-4078-a37e-0a9678958ce4 //
        // Choice: Hi there! What's happening here? - a5bd7684-07de-493a-95ad-07b36f87717b //
        public bool Peterson_9a9ffe5b55924078a37e0a9678958ce4_a5bd768407de493a95ad07b36f87717b()
        {
            return (true);
        }
        // From Node: d302f0c8-4771-4cf6-97da-7951267a4eb2 //
        // Choice: I'll have to come back later. - 40b3895c-879c-4a02-998d-8aae82f8f01d //
        public bool Peterson_d302f0c847714cf697da7951267a4eb2_40b3895c879c4a02998d8aae82f8f01d()
        {
            return (true);
        }
        // From Node: d302f0c8-4771-4cf6-97da-7951267a4eb2 //
        // Choice: Sure, I can give you a hand! - 47faccce-725b-40dd-a270-ec2c9af7e54b //
        public bool Peterson_d302f0c847714cf697da7951267a4eb2_47faccce725b40dda270ec2c9af7e54b()
        {
            return (true);
        }
        // From Node: 6e9ab8e1-dce2-4fcb-844f-03fa931b53e3 //
        // Choice: No problem! I'll be back soon! - b6e99962-d574-438b-b183-b40014fd58a5 //
        public bool Peterson_6e9ab8e1dce24fcb844f03fa931b53e3_b6e99962d574438bb183b40014fd58a5()
        {
            return (true);
        }
        // From Node: db0ef3e6-662a-4188-8cef-d98a4301607a //
        // Choice: Is this all you need? - 974d4b74-7c00-4131-9a8d-4d030b958d3e //
        public bool Peterson_db0ef3e6662a41888cefd98a4301607a_974d4b747c0041319a8d4d030b958d3e()
        {
            return (true);
        }
        // From Node: dd834658-53fb-46d0-880a-d04636733336 //
        // Choice: What is it? - 7c723311-f356-405b-b4bf-9d684956b4ac //
        public bool Peterson_dd83465853fb46d0880ad04636733336_7c723311f356405bb4bf9d684956b4ac()
        {
            return (true);
        }
        // From Node: edbd696d-4812-42a6-921e-ed9564edccbc //
        // Choice: Sure thing! - 4221e644-a2d7-487d-b8a4-40836e69c589 //
        public bool Peterson_edbd696d481242a6921eed9564edccbc_4221e644a2d7487db8a440836e69c589()
        {
            return (true);
        }
        // From Node: edbd696d-4812-42a6-921e-ed9564edccbc //
        // Choice: Hmm. I'm not sure. - e64912f6-7d9a-4911-aaa5-62b9f1d5d807 //
        public bool Peterson_edbd696d481242a6921eed9564edccbc_e64912f67d9a4911aaa562b9f1d5d807()
        {
            return (true);
        }
        // From Node: 7abdb489-950d-4557-9271-3ccfd1a9e959 //
        // Choice: Not Yet. - e45cd6c5-6b6a-4815-874d-003c4f98dd36 //
        public bool Peterson_7abdb489950d455792713ccfd1a9e959_e45cd6c56b6a4815874d003c4f98dd36()
        {
            return (true);
        }
        // From Node: 7abdb489-950d-4557-9271-3ccfd1a9e959 //
        // Choice: Haven't started looking. - 5eba6cc7-6f02-44a1-acbc-af4a04360239 //
        public bool Peterson_7abdb489950d455792713ccfd1a9e959_5eba6cc76f0244a1acbcaf4a04360239()
        {
            return (true);
        }
        // From Node: 6adce4b6-1d68-482d-9716-58feab87a93f //
        // Choice: Okay! - f8d2d2a9-5e59-427b-92ba-a351e2ebfd48 //
        public bool Peterson_6adce4b61d68482d971658feab87a93f_f8d2d2a95e59427b92baa351e2ebfd48()
        {
            return (true);
        }
        // From Node: 40c089d8-1344-421e-b2ac-2ff4e70667f7 //
        // Choice: Yeah! Here she is! - ca84e5ec-d441-4ff7-b67d-189d3cbe5ed1 //
        public bool Peterson_40c089d81344421eb2ac2ff4e70667f7_ca84e5ecd4414ff7b67d189d3cbe5ed1()
        {
            return (true);
        }
        // From Node: cb9d79f5-3b68-42f5-ac21-fccdf73207dd //
        // Choice: Another one? - 21646ea9-29c0-4f2c-b38b-7b5ea27fe63e //
        public bool Peterson_cb9d79f53b6842f5ac21fccdf73207dd_21646ea929c04f2cb38b7b5ea27fe63e()
        {
            return (true);
        }
        // From Node: cb9d79f5-3b68-42f5-ac21-fccdf73207dd //
        // Choice: Okay... - 8733c1cd-8f5a-4f16-95be-1786eb25cb74 //
        public bool Peterson_cb9d79f53b6842f5ac21fccdf73207dd_8733c1cd8f5a4f1695be1786eb25cb74()
        {
            return (true);
        }
        // From Node: 39b7b714-a010-46b1-ada1-df11c83499c5 //
        // Choice: Who's Niko? - 3f273087-5b1b-40ae-93ef-a2ecf33aae0f //
        public bool Peterson_39b7b714a01046b1ada1df11c83499c5_3f2730875b1b40ae93efa2ecf33aae0f()
        {
            return (true);
        }


        // Condition Checks //
        // Condition From Node: 766d4f79-4979-4856-996a-8ed6ec13fd1c //
        public bool Peterson_766d4f7949794856996a8ed6ec13fd1c() {
            return (Stage.ContainsStage(StageType.PetersonQuestPoopBegin));
        }
        // Condition From Node: a0974ed0-08c2-4504-babd-efd689ee7747 //
        public bool Peterson_a0974ed008c24504babdefd689ee7747() {
            return (Stage.ContainsStage(StageType.PoopPile));
        }
        // Condition From Node: 11756253-8777-45e9-8b60-769200b7d095 //
        public bool Peterson_11756253877745e98b60769200b7d095() {
            return (Stage.ContainsStage(StageType.PetersonQuestPoopEndPetBegin));
        }
        // Condition From Node: a3712b13-3ac8-41f6-8fd7-3e3210fbceba //
        public bool Peterson_a3712b133ac841f68fd73e3210fbceba() {
            return (Stage.ContainsStage(StageType.PetersonQuestPetEndFindNikoBegin));
        }
        // Condition From Node: 79018712-6255-4f61-9feb-de329cead64b //
        public bool Peterson_7901871262554f619febde329cead64b() {
            return (Stage.ContainsStage(StageType.ReturnPet));
        }


        // Event Functions //
        // Event From Node: bcedffc0-fdc3-48fb-93a3-6ae6867d6292 //
        public void Peterson_bcedffc0fdc348fb93a36ae6867d6292() {
/*
Notes:
Ask to pick up poop
*/
        }
        // Event From Node: 67815e7f-39ab-4e13-8655-ebc27c93ba97 //
        public void Peterson_67815e7f39ab4e138655ebc27c93ba97() {
/*
Notes:
Filler for not finished picking
up the poop
*/
        }
        // Event From Node: c44846d0-3b17-4190-a96d-d5fc52b7581d //
        public void Peterson_c44846d03b174190a96dd5fc52b7581d() {
/*
Notes:
After picking up poop, ask to find pet
*/
        }
        // Event From Node: 80d8ae35-9178-4425-9e23-ad013f9f0377 //
        public void Peterson_80d8ae35917844259e23ad013f9f0377() {
/*
Notes:
Filler for if the pet isn't found
*/
        }
        // Event From Node: e62c7570-f9e0-4bd9-9eb4-72ea6abab000 //
        public void Peterson_e62c7570f9e04bd99eb472ea6abab000() {
/*
Notes:
After pet is found, redirect to niko
*/
        }
        // Event From Node: d270dbc2-8cbb-405e-84ec-719fa8c36ff3 //
        public void Peterson_d270dbc28cbb405e84ec719fa8c36ff3() {
/*
Notes:
Filler talk to niko
*/
        }
        // Event From Node: 824caa51-19a8-40b1-8998-d8a62db5d164 //
        public void Peterson_824caa5119a840b18998d8a62db5d164() {
Stage.Instance.CurrentStage = StageType.PoopPile;
        }
        // Event From Node: 104ba15a-5f92-4928-ab83-6dc95b040ef0 //
        public void Peterson_104ba15a5f924928ab836dc95b040ef0() {
Stage.Instance.CurrentStage = StageType.ReturnPet;
        }

    }
}
