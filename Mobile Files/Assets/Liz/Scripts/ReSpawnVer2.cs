using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ReSpawnVer2 : MonoBehaviour
{
    public bool Alive = true;

    public GameObject player;
    public GameObject spawnpoint;
    public ParticleSystem particles;

    
    void Update()
    {
        if (Alive == false)
        {
            player.transform.position = spawnpoint.transform.position;
            Alive = true;
            particles.Play();
            spawnpoint.GetComponent<AudioSource>().Play();
            
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
