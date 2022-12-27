using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project.Concreates.Collect;
using Project.Abstract.Collect;

public class CollectorManager : MonoBehaviour
{
    ICollect collectOil;

    private void Start() 
    {
        collectOil = GetComponent<CollectOil>();
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            collectOil.CollectObj(other.gameObject);
        }
    }
    
}
