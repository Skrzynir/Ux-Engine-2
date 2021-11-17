using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCheck : MonoBehaviour
{
    public bool HasOrb = false;
    public bool Trigger = false;

    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Trigger == true)
        {
            HasOrb = true;
            Debug.Log("HasOrb");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Orb")
        {
            Trigger = true;
            Debug.Log("Trigger");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Trigger = false;
    }
}
