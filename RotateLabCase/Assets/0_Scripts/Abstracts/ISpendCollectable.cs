using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Abstract.Spend
{
    public interface ISpendCollectable
    {
        void SpendCollectable(List<GameObject> _collectableList,int _spendNumber);
    }

}
