using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSwitchPH : MonoBehaviour
{
   
    public GameObject BlackWord;
    public GameObject ColourWorld;

    public bool BlackWorldActive = true;
    public bool ColourWorldActive = false;

    private void Start()
    {
        BlackWord.SetActive(BlackWorldActive);
        ColourWorld.SetActive(ColourWorldActive);

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            BlackWord.SetActive(BlackWorldActive = !BlackWorldActive);
            ColourWorld.SetActive(ColourWorldActive = !ColourWorldActive);
            Debug.Log("Space pressed");
        }
    }


}
