using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCollection : MonoBehaviour
{
    public GameObject player;
    public bool pass = false;
    OrbCheck orb;
    public bool collect = false;
    [SerializeField]
    public AudioSource source;
    public AudioClip orbget;
    

    void Start()
    {
        orb = player.GetComponent<OrbCheck>();       
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && pass == true)
        {
            orb.HasOrb = true;
            collect = true;
            Destroy(gameObject);
            source.PlayOneShot(orbget);            
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
        if (collision.gameObject.tag == "Player")
        {
            pass = false;
        }
    }
}
