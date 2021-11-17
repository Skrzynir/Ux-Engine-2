using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawnVer2 : MonoBehaviour
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
                
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Alive = false;
        }
    }
}
