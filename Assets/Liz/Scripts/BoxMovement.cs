﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D boxRb;
       
    //private bool triggerEntered = false;

    public float speed = 10;
    public bool isFloating = false;

    void Start()
    {
        boxRb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
      /*  if (Input.GetKeyDown(KeyCode.Space) && triggerEntered == true)
        {
            Vector3 move = new Vector3(0, 0, 0);
            gameObject.transform.position += move * Time.deltaTime * speed;
        }*/
    }

  /*  private void OnTriggerEnter2D(Collider2D other)
    {
        triggerEntered = true;        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        triggerEntered = false;
    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            isFloating = false;
        }
        if (collision.collider.tag == "Player")
        {
            Vector3 move = new Vector3(0, 0, 0);
            gameObject.transform.position += move * Time.deltaTime * speed;
        }
        
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            isFloating = true;
        }
        if (collision.collider.tag == "Player")
        {
            boxRb.velocity = Vector3.zero;
        }
    }
}
