using System.Collections;
using System.Collections.Generic;
using Project.Abstract.Inputs;
using Project.Abstract.Rotations;
using UnityEngine;

namespace Project.Concreates.Rotations
{
    public class JoystickRotate : MonoBehaviour , IPlayerInput
    {
        [SerializeField] private FloatingJoystick floatingJoystick;
        public float horizontal { get; set; }
        public float vertical { get; set; }

        private void Update()
        {
            SetJoystickRotate();
        }

        public void SetJoystickRotate()
        {
            horizontal = floatingJoystick.Horizontal;
            vertical = floatingJoystick.Vertical;
        }

    }
}

