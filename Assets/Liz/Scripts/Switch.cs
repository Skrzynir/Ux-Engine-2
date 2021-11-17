using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool SwitchToPress = false;
    public bool SwitchActive = false;

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && SwitchToPress == true)
        {
            SwitchActive = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {            
            SwitchToPress = true;
        }
    }
}
