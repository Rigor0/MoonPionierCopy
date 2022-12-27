using System.Collections;
using System.Collections.Generic;
using Project.Abstract.ObjCreate;
using UnityEngine;
using DG.Tweening;


namespace Project.Concreates.ObjCreate
{
    public class OilCreator : MonoBehaviour, ICreate
    {
        private List<GameObject> oilList = new List<GameObject>();

        public IEnumerator CreateObject(float _timeInterval, GameObject _prefab, Transform _exitPoint)
        {
            float oilPosCounter = 3.5f;

            while (oilList.Count <= ObjectPoolManager.instance.pools[0].size)
            {
                
                float oilCount = oilList.Count;
                int rowCount = (int)oilCount / 5;

                if (oilCount %5 == 0)
                {
                    oilPosCounter = 3.5f;
                }
                
                GameObject oil = ObjectPoolManager.instance.GetPooledObject("Oil");
                oil.transform.position = new Vector3(_exitPoint.position.x, _exitPoint.position.y, _exitPoint.position.z 
                +((float)rowCount));
                OilPosAnimation(oil, _exitPoint, oilPosCounter);
                oilList.Add(oil);

                oilPosCounter += 1;
                yield return new WaitForSeconds(_timeInterval);
            }
        }

        public void OilPosAnimation(GameObject _oilObj, Transform _exitPoint, float _oilPosCounter)
        {
            Sequence sequence = DOTween.Sequence();
            sequence.Append(_oilObj.transform.DOMoveX((_exitPoint.transform.position.x + _oilPosCounter) / 1, 1));
            sequence.Join(_oilObj.transform.DORotate(new Vector3(-90, 0, -0), 1));
        }
    }
}

