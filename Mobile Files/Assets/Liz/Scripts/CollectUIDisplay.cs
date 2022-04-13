using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectUIDisplay : MonoBehaviour
{
    public Image OrbtoCollect;

    void Start()
    {
        OrbtoCollect.enabled = true;
        StartCoroutine(ActiveImage());
    }

   IEnumerator ActiveImage()
    {
        yield return new WaitForSecondsRealtime(20.0f);
        OrbtoCollect.enabled = false;
    }

}
