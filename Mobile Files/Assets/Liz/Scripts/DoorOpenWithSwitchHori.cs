﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenWithSwitchHori : MonoBehaviour
{
    public GameObject SwitchObject;
    Switch press;
    [SerializeField]
    public AudioSource source;
    public AudioClip dooropen;
    public AudioClip doorshut;


    void Start()
    {
        press = SwitchObject.GetComponent<Switch>();        
    }


    void Update()
    {
        if (press.SwitchActive == true)
        {
            gameObject.SetActive(false);
            source.PlayOneShot(dooropen);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            source.PlayOneShot(doorshut);
        }
    }
}
