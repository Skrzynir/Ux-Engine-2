using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpenWithOrbs : MonoBehaviour
{
    public GameObject player;
    OrbCheck orb;
    public ParticleSystem PS;
    [SerializeField]
    public AudioSource source;
    public AudioClip dooropen;
    public AudioClip doorshut;

    void Start()
    {       
        orb = player.GetComponent<OrbCheck>();
    }    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && orb.HasOrb == true)
        {
            source.PlayOneShot(dooropen);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (collision.gameObject.tag == "Player" && orb.HasOrb == false)
        {
            source.PlayOneShot(doorshut);
        }
    }    
}
