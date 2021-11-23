using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPrompts : MonoBehaviour
{    
    public Image pressE;    

    void Start()
    {
        pressE.enabled = false;       
    }

   

    private void OnTriggerEnter2D(Collider2D other)
    {
        pressE.enabled = true;        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        pressE.enabled = false;
    }
}
