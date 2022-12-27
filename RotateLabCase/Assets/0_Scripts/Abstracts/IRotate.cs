using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Abstract.Rotations
{
    public interface IRotate
    {
        void SetRotation(float _horizontal , float _vertical , Transform _transform);
    }
}

