using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ObjectPoolManager : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }
    public Dictionary<string, Queue<GameObject>> poolDictionary;
    public List<Pool> pools;

    #region Singleton
    public static ObjectPoolManager instance { get; private set; }
    private void OnEnable()
    {
        instance = this;
    }
    #endregion

    void Awake()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pool.tag, objectPool);
        }
    }


    public GameObject GetPooledObject(string tag)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.Log("Pool does not exist");
            return null;
        }

        GameObject objectToUse = poolDictionary[tag].Dequeue();
        objectToUse.SetActive(true);

        poolDictionary[tag].Enqueue(objectToUse);
        return objectToUse;

    }
}
