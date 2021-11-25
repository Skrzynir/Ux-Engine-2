using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField]
    public AudioClip steps;
    public AudioClip collection;
    public AudioClip doorOpen;

    private AudioSource source;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            
        }
    }
}
