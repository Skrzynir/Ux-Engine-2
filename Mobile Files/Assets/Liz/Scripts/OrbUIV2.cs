using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrbUIV2 : MonoBehaviour
{
    public Image orbImg;
    public GameObject orbObj;
    OrbCollection orbCol;
    
    void Start()
    {
        orbImg.enabled = false;
        orbCol = orbObj.GetComponent<OrbCollection>();
    }

    
    void Update()
    {
        if (orbCol.collect == true)
        {
            orbImg.enabled = true;
        }
    }
}
