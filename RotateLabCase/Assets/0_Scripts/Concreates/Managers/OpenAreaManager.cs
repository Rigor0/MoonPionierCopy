using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project.Abstract.OpenArea;
using Project.Concreates.OpenArea;
using Project.Concreates.Collect;
using Project.Abstract.Spend;
using Project.Concreates.Spend;



public class OpenAreaManager : MonoBehaviour
{
    IOpenArea openArea;
    ISpendCollectable spendOil;
    private LevelFinisher levelFinisher;
    public List<GameObject> treadMillAreas;
    public List<GameObject> objectsToOpen;
    private int areaCost;
    public static bool isLevelFinish;

    public enum AreaType
    {
        Drill,
        AI,
        FinishArea
    }
    public AreaType areaType;

    void Start()
    {
        openArea = new OpenArea();
        spendOil = new SpendOil();    
    }

    private void OnTriggerEnter(Collider other)
    {
        int currentOil = CollectOil.oilList.Count;
        Debug.Log(currentOil);
        if (other.gameObject.CompareTag("Player"))
        {
            switch (areaType)
            {
                case AreaType.Drill :
                areaCost = 5;
                openArea.OpenArea(objectsToOpen[0],currentOil,areaCost,this.GetComponent<Collider>());
                if (OpenArea.isOpened)
                {
                    spendOil.SpendCollectable(CollectOil.oilList,areaCost);
                    for (int i = 0; i <treadMillAreas.Count; i++)
                    {
                        treadMillAreas[0].gameObject.SetActive(true);
                    }  
                }        
                break;

                case AreaType.AI :
                areaCost = 4;
                openArea.OpenArea(objectsToOpen[0],currentOil,areaCost,this.GetComponent<Collider>());
                if (OpenArea.isOpened)
                {
                    OilDrillManager.createOilInterval /= 2;
                    spendOil.SpendCollectable(CollectOil.oilList,areaCost);
                    ObjectPoolManager.instance.GetPooledObject("AI"); 
                }  
                break; 

                case AreaType.FinishArea :
                areaCost = 20;
                spendOil.SpendCollectable(CollectOil.oilList,areaCost);
                isLevelFinish = true;
                break;
                
            }
        }
    }
}
