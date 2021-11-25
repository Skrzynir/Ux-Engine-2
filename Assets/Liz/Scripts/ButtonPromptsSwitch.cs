using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPromptsSwitch : MonoBehaviour
{
    public Image Activate;

    Switch grey;



    public void Start()
    {
        Activate.enabled = false;
        grey = GetComponent<Switch>();
        
        
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        Activate.enabled = true;

        if (grey.SwitchActive == true)
        {
            Activate.enabled = false;
            
           
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Activate.enabled = false;
    }
}

