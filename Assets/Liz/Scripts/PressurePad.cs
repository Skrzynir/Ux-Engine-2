using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
                
    public bool PadActive = false;
    public bool PadPress = false;
        
   
    public void Update()
    {
        if (PadPress == true)
        {            
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.25f * Time.deltaTime * 10, 0);
            PadActive = true;
        }

                
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            PadPress = true;            
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            PadPress = false;
        }
    }

    
}
