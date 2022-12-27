using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Abstract.CreatedObjVariables
{
    public class IObjCreateVariable : MonoBehaviour
    {
        float creationInterval { get; set; }
        GameObject createdObjPrefab { get; set; }
        Transform exitPoint { get; set; }
    }
}

