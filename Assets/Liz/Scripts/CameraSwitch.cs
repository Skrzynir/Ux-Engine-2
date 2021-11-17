using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject PlayerCamera;
    public GameObject AniCamera;

    private IEnumerator coroutine;

      void Start()
    {
       
        StartCoroutine(OpenScene());
        
        AniCamera.SetActive(true);
        PlayerCamera.SetActive(false);
               
    }

    IEnumerator OpenScene()
    {
        yield return new WaitForSecondsRealtime(7.5f);

        AniCamera.SetActive(false);
        PlayerCamera.SetActive(true);
    }


}
