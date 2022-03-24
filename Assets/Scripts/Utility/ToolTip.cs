using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Utility
{
    
    public class ToolTip : MonoBehaviour
    {
        public static ToolTip Instance { get; private set; }

        [SerializeField]
        private TextMeshProUGUI Hover;
        [SerializeField]
        private TextMeshProUGUI Use;
        [SerializeField]
        private TextMeshProUGUI Hold;

        [HideInInspector]
        public string HoverText;
        [HideInInspector]
        public string UseText;
        [HideInInspector]
        public string HoldText;

        public bool isEnabled = true;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            Clear();
        }

        public void Clear() 
        {
            HoverText = string.Empty;
            UseText = string.Empty;
            HoldText = string.Empty;
        }

        void Update()
        {
            if (!isEnabled)
            {
                if (Hover != null)
                    Hover.text = string.Empty;
                if (Use != null)
                    Use.text = string.Empty;
                if (Hold != null)
                    Hold.text = string.Empty;
                return;
            }
            if(Hover != null)
                Hover.text = ToolTipIcons.ResolveString(HoverText);
            if (Use != null)
                Use.text = ToolTipIcons.ResolveString(UseText);
            if (Hold != null)
                Hold.text = ToolTipIcons.ResolveString(HoldText);
        }
    }
}