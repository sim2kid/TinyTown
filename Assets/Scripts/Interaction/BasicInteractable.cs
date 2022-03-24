using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction {
    public class BasicInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField]
        private string _hoverText;

        public GameObject GameObject { 
            get 
            {
                if(this)
                    return this.gameObject;
                return null;
            }  
        }
        public string InteractText { get => _hoverText; }
        public ClickState ClickState { get; protected set; }

        public void SetHoverText(string newText) 
        {
            _hoverText = newText;
        }

        protected virtual void Start()
        {
            ClickState = ClickState.None;
            Console.HideInDebugConsole();
        }

        public virtual void Down()
        {
            ClickState = ClickState.Down;
            Console.LogDebug($"{name} has recived a DownClick event.");
        }

        public virtual void Enter()
        {
            ClickState = ClickState.Enter;
            Console.LogDebug($"{name} has recived an Enter event.");
        }

        public virtual void Exit()
        {
            ClickState = ClickState.Exit;
            if(this)
                Console.LogDebug($"{name} has recived an Exit event.");
        }

        public virtual void Hold()
        {
            ClickState = ClickState.Hold;
        }

        public virtual void Hover()
        {
            ClickState = ClickState.Hover;
        }

        public virtual void Up()
        {
            ClickState = ClickState.Up;
            Console.LogDebug($"{name} has recived an UpClick event.");
        }

        public virtual void LateUp()
        {
            
        }
    }
}