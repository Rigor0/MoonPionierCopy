using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project.Abstract.OpenArea;

namespace Project.Concreates.OpenArea
{
    public class OpenArea : IOpenArea
    {
        public static bool isOpened;
        void IOpenArea.OpenArea(GameObject _areaType, int _currentOil, int _areaCost,Collider _areaCollider)
        {
            if (_currentOil >= _areaCost )
            {
                isOpened = true;
                for (int i = 0; i < _areaCost; i++)
                {
                    _areaCost -= 1;
                    _currentOil -=1;
                }
                _areaCollider.enabled = false;
                _areaType.SetActive(true);
            }
            else
            {
                isOpened = false;
            }

        }
    }

}
