using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class LevelFinisher : MonoBehaviour
{
    public GameObject mainCamera,spaceRocket;

    private void Update() 
    {
        if (OpenAreaManager.isLevelFinish)
        {
            Debug.Log("Works");
            CameraAnim();
            SpaceRocketAnim();
        }
    }

    public void CameraAnim()
    {
        mainCamera.transform.DOShakePosition(4,1);
    }

    public void SpaceRocketAnim()
    {
        spaceRocket.transform.DOMoveY(60,4);
    }
}
