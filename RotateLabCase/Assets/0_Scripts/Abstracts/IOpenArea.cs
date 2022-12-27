using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Abstract.OpenArea
{
    public interface IOpenArea
    {
        void OpenArea(GameObject _areaType,int _currentOil,int areaCost,Collider _areaCollider);
    }
}

