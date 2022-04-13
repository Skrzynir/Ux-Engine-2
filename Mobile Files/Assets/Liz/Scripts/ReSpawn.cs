using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public bool Alive = true;

    public GameObject player;
    public GameObject spawnpoint;

    
    void Update()
    {
        if (Alive == false)
        {
            player.transform.position = spawnpoint.transform.position;
            Alive = true;
        }

        if (player.transform.position.y < -20)
        {
            Alive = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hazard")
        {
            Alive = false;
            
        }
    }
}
