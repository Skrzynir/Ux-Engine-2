using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCheck : MonoBehaviour
{
    public bool HasOrb = false;
    public bool Trigger = false;

    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Trigger == true)
        {
            HasOrb = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Orb")
        {
            Trigger = true;           
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Trigger = false;
    }
}
