﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenWithPhotos : MonoBehaviour
{
    public int _requiredNumPhotos = 3;
    public GameObject part;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(PhotoPickUp.NumPhotosCollected == _requiredNumPhotos)
            {
                Debug.Log("doorshouldopen");
                Instantiate(part, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}