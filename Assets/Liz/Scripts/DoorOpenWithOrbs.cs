using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpenWithOrbs : MonoBehaviour
{
    public GameObject player;
    OrbCheck orb;
    public ParticleSystem PS;
    
    void Start()
    {
       
        orb = player.GetComponent<OrbCheck>();
    }

    void Update()
    {
        if (orb.HasOrb == true)
            {

            PS.Play();
            Debug.Log("doorcanopen");

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
