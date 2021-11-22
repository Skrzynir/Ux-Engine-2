using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject PlayerCamera;
    public GameObject AniCamera;

    RenderChange RC;
    public GameObject fadeObject;

    private IEnumerator coroutine;

      void Start()
    {
        RC = fadeObject.GetComponent<RenderChange>();
        StartCoroutine(OpenScene());
        
        AniCamera.SetActive(true);
        PlayerCamera.SetActive(false);
               
    }

    IEnumerator OpenScene()
    {
        yield return new WaitForSecondsRealtime(7.0f);
        RC.ScreenFade();

        AniCamera.SetActive(false);
        PlayerCamera.SetActive(true);
    }


}
