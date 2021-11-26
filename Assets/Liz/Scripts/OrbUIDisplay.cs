using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OrbUIDisplay : MonoBehaviour
{
    public Image yellow;
    public Image red;
    public Image blue;

    public GameObject YellowOrb;
    public GameObject RedOrb;
    public GameObject BlueOrb;

    OrbCollection orbY;
    OrbCollection orbR;
    OrbCollection orbB;

    

    void Start()
    {
        yellow.enabled = false;
        red.enabled = false;
        blue.enabled = false;

        orbY = YellowOrb.GetComponent<OrbCollection>();
        orbR = RedOrb.GetComponent<OrbCollection>();
        orbB = BlueOrb.GetComponent<OrbCollection>();

        

    }

    
    void Update()
    {
        if (orbY.collect == true)
        {
            yellow.enabled = true;
        }

        if (orbR.collect == true)
        {
            red.enabled = true;
        }

        if (orbB.collect == true)
        {
            blue.enabled = true;
        }
    }

   /* private void Awake()
    {        
        DontDestroyOnLoad(this.gameObject);
    }*/
}
