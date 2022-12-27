using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project.Abstract.Inputs;


namespace Project.Concreates.Inputs
{
    public class JoystickInput :MonoBehaviour, IPlayerInput
    {
        [SerializeField] private FloatingJoystick floatingJoystick;

        public float horizontal {get; set; }

        public float vertical {get; set; }

        private void Update() 
        {
            SetJoystickInput();
        }

        public void SetJoystickInput()
        {
             horizontal = floatingJoystick.Horizontal;
             vertical = floatingJoystick.Vertical;
        }      
    }
}

