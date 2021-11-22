using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject player;

    private bool triggerEntered = false;    

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.E) && triggerEntered == true)
        {
            player.transform.position = teleportTarget.transform.position;            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        triggerEntered = true;               
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        triggerEntered = false;
    }
}
