using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject player;

    AudioSource AS;

    private void Start()
    {
        AS = GetComponent<AudioSource>();
    }

    private bool triggerEntered = false;    

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.E) && triggerEntered == true)
        {
            player.transform.position = teleportTarget.transform.position;
            AS.Play();
            AudioVolume();
            
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

    void AudioVolume()
    {
        if (AS.isPlaying == true)
        {
            StartCoroutine(Fade());
            
        }
    }

    IEnumerator Fade()
    {
        for (float AVolume =  1; AVolume >0.5; AVolume -= 0.1f)
        {
            AS.volume = AVolume;
            yield return null;
        }
    }
}
