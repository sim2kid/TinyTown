using Player.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player {
    public class PlayerController : MonoBehaviour
    {
        public MovementController movement;
        public HeadMovement headMovement;


        void Start()
        {
            Utility.Pause.Instance.OnPause.AddListener(OnPause);
            Utility.Pause.Instance.OnUnPause.AddListener(OnUnPause);
            if (Utility.Pause.Instance.Paused)
            {
                OnPause();
            }
            else 
            {
                OnUnPause();
            }
        }

        void OnPause()
        {
            movement.isEnabled = false;
            headMovement.gameObject.SetActive(false);
        }

        void OnUnPause()
        {
            movement.isEnabled = true;
            headMovement.gameObject.SetActive(true);
        }
    }
}