using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField]
    public AudioClip steps;
    public AudioClip switchAct;
    public AudioClip doorOpen;

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

   

    public void playAudio(AudioClip clip)
    {
        source.PlayOneShot(clip);
    }
}
