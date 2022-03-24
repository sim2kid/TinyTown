using Player.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player {
    public class PlayerController : MonoBehaviour
    {
        public MovementController movement;
        public HeadMovement headMovement;

        private InputAction pause;
        private DialogueSystem.Demo.DialogueController dc;


        void Start()
        {
            var input = FindObjectOfType<PlayerInput>();
            pause = input.actions["Pause"];
            dc = FindObjectOfType<DialogueSystem.Demo.DialogueController>();
            Utility.Pause.Instance.OnPause.AddListener(OnPause);
            Utility.Pause.Instance.OnUnPause.AddListener(OnUnPause);

            dc.OnConvoStart.AddListener(OnConvoStart);
            dc.OnConvoEnd.AddListener(OnConvoEnd);

            if (Utility.Pause.Instance.Paused)
            {
                OnPause();
            }
            else 
            {
                OnUnPause();
            }
        }

        private void Update()
        {
            if(pause.triggered && !dc.InConvo) 
            {
                Utility.Pause.Instance.SetPause(!Utility.Pause.Instance.Paused);
            }
        }

        void OnPause()
        {
            movement.isEnabled = false;
            headMovement.isEnabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        void OnUnPause()
        {
            movement.isEnabled = true;
            headMovement.isEnabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        void OnConvoStart() 
        {
            Utility.ToolTip.Instance.isEnabled = false;
        }

        void OnConvoEnd() 
        {
            Utility.ToolTip.Instance.isEnabled = true;
        }
    }
}