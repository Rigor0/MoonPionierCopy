using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Project.Abstract.Movements;
using Project.Concreates.Movements;
using Project.Concreates.AI;


[RequireComponent(typeof(NavMeshAgent),typeof(Rigidbody))]
public class AIManager : MonoBehaviour
{
    IMove aiMovement;
    private GameObject treadMill;
    void Start()
    {
        aiMovement = new AI(GetComponent<NavMeshAgent>());
        treadMill = GameObject.FindWithTag("Treadmill");
    }

    
    void Update()
    {
        aiMovement.Movement(treadMill.transform.position.x,treadMill.transform.position.z,treadMill.transform);
        transform.rotation = Quaternion.LookRotation(-treadMill.transform.position);
        if (OpenAreaManager.isLevelFinish)
        {
            gameObject.SetActive(false);
        }
    }
}
