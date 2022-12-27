using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Project.Concreates.Collect;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI oilCounterText,areaToOpenText;
    
    void Update()
    {
        oilCounterText.text = CollectOil.oilList.Count.ToString();
    }
}
