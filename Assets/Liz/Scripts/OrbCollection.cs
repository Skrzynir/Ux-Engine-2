using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCollection : MonoBehaviour
{
    public GameObject player;
    public bool pass = false;
    OrbCheck orb;
    public bool collect = false;
    AudioSource AS;

    void Start()
    {
        orb = player.GetComponent<OrbCheck>();
        AS = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && pass == true)
        {
            orb.HasOrb = true;
            collect = true;
            Destroy(gameObject);
            AS.Play();
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pass = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pass = false;
    }
}
