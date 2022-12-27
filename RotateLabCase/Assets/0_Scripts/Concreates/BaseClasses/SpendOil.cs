using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project.Abstract.Spend;
using Project.Concreates.OpenArea;
using Project.Abstract.OpenArea;
using DG.Tweening;

namespace Project.Concreates.Spend
{
    public class SpendOil : ISpendCollectable
    {
        public void SpendCollectable(List<GameObject> _collectableList, int _spendNumber)
        {
            for (int i = 0; i < _spendNumber; i++)
            {
                _collectableList[_collectableList.Count - 1].gameObject.transform.DOJump(new Vector3(0, -1, 0), 1, 1, 1)
                .OnComplete(() =>
                {
                    _collectableList[_collectableList.Count - 1].gameObject.SetActive(false);
                    _collectableList.RemoveAt(_collectableList.Count - 1);
                });
            }
        }
    }
}

