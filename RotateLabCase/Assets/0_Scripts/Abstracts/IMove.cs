using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Abstract.Movements
{
    public interface IMove
    {
        void Movement(float _horizontal , float _vertical, Transform _transform);
    }
}

