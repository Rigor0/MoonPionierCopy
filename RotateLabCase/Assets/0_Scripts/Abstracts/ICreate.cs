using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Abstract.ObjCreate
{
    public interface ICreate
    {
        IEnumerator CreateObject(float _timeInterval, GameObject _prefab, Transform _exitPoint);
    }
}

