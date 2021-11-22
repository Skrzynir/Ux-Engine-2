using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPrompts : MonoBehaviour
{    
    public Image pressE;

    Teleportation interact;

    void Start()
    {
        pressE.enabled = false;       
    }

   

    private void OnTriggerEnter2D(Collider2D other)
    {
        pressE.enabled = true;
        Debug.Log("enabled");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        pressE.enabled = false;
    }
}
