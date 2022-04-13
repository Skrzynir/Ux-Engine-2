using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject player;
        
    AudioSource AS;

    PlayerInput playerInput;

    private void Start()
    {
        playerInput = new PlayerInput();
        playerInput.PlayerMap.Interact.performed += c => Interact();
        playerInput.Enable();
        
        AS = GetComponent<AudioSource>();
    }

    private bool triggerEntered = false;    


    public void Interact()
    {
    
    Debug.Log("tele");
    
    if (triggerEntered == true)
        {
            player.transform.position = teleportTarget.transform.position;
            AS.Play();
            AudioVolume();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        triggerEntered = true;  
        Debug.Log ("true");            
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
        for (float AVolume = 1; AVolume > 0.5; AVolume -= 0.1f)
        {
            AS.volume = AVolume;
            yield return null;
        }
    }
}
