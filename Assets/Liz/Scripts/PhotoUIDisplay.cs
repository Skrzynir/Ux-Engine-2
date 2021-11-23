using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoUIDisplay : MonoBehaviour
{
    public Image yellowP;
    public Image redP;
    public Image blueP;

    public GameObject YellowPhoto;
    public GameObject RedPhoto;
    public GameObject BluePhoto;

    PhotoCollection photoY;
    PhotoCollection photoR;
    PhotoCollection photoB;

    void Start()
    {
        yellowP.enabled = false;
        redP.enabled = false;
        blueP.enabled = false;

        photoY = YellowPhoto.GetComponent<PhotoCollection>();
        photoR = RedPhoto.GetComponent<PhotoCollection>();
        photoB = BluePhoto.GetComponent<PhotoCollection>();

    }

    void Update()
    {
        if (photoY.collect == true)
        {
            yellowP.enabled = true;
        }

        if (photoR.collect == true)
        {
            redP.enabled = true;
        }

        if (photoB.collect == true)
        {
           blueP.enabled = true;
        }
    }

    
}
