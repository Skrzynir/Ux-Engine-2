using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardPH : MonoBehaviour
{
    public GameObject player;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (player.tag == "Player")
        {
            print("Player has been killed");
        }
           

    }
}
