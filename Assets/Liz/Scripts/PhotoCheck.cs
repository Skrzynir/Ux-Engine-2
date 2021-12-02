using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoCheck : MonoBehaviour
{
    public bool HasPhotoY = false;
    public bool HasPhotoR = false;
    public bool HasPhotoB = false;
    
    public bool TrigY = false;
    public bool TrigR = false;
    public bool TrigB = false;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && TrigY == true)
        {
            HasPhotoY = true;            
        }

        if (Input.GetKeyDown(KeyCode.E) && TrigR == true)
        {
            HasPhotoR = true;           
        }

        if (Input.GetKeyDown(KeyCode.E) && TrigB == true)
        {
            HasPhotoB = true;            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.gameObject.name == "PhotoY")
        {
            TrigY = true;
        }

        if (collision.gameObject.name == "PhotoR")
        {
            TrigR = true;
        }

        if (collision.gameObject.name == "PhotoB")
        {
            TrigB = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        TrigY = false;
        TrigR = false;
        TrigB = false;
    }
}
