using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project.Abstract.Collect;
using DG.Tweening;
using Project.Concreates.ObjCreate;
using Project.Abstract.ObjCreate;


namespace Project.Concreates.Collect
{
    public class CollectOil : MonoBehaviour, ICollect
    {
        ObjectPoolManager objectPoolManager;
        private int oilCapacity;
        public GameObject collectPoint;
        ICollect oilCreator;
        public static List<GameObject> oilList = new List<GameObject>();

        void Start()
        {
            objectPoolManager = ObjectPoolManager.instance;
        }

        public void CollectObj(GameObject _oil)
        {
            _oil.transform.DOJump(collectPoint.transform.position,2f,1,1f).OnComplete(() =>{
            _oil.transform.SetParent(collectPoint.transform,true);
            _oil.transform.localPosition = new Vector3(0,(float)oilList.Count /35,0);
            _oil.transform.rotation = Quaternion.identity;
            _oil.gameObject.GetComponent<Collider>().enabled = false;
            oilList.Add(_oil);
            });
            
        }
    }
}
