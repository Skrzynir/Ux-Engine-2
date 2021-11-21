using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenWithOrbs : MonoBehaviour
{
    public GameObject player;
    OrbCheck orb;
    public GameObject doorParticle;
    
    void Start()
    {
        orb = player.GetComponent<OrbCheck>();
    }

    void Update()
    {
        if (orb.HasOrb == true)
            {
            
            Instantiate(doorParticle, transform.position, transform.rotation);
            Debug.Log("doorcanopen");


            }

        if (orb.HasOrb == false)
        {
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && orb.HasOrb == true)
        {
            Debug.Log("doorshouldopen");           
            
        }
    }
    
}
