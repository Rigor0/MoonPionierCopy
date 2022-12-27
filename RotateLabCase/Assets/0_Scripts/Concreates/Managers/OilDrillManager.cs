using System.Collections;
using System.Collections.Generic;
using Project.Abstract.ObjCreate;
using Project.Concreates.ObjCreate;
using UnityEngine;

public class OilDrillManager : MonoBehaviour
{
    public static float createOilInterval = 6f;
    public GameObject oilPrefab;
    public Transform exitPoint;
    ICreate oilCreator;
    void OnEnable()
    {
        oilCreator = GetComponent<OilCreator>();
        StartCoroutine(oilCreator.CreateObject(createOilInterval,oilPrefab,exitPoint));
    }
}
