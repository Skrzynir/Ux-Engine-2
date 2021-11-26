﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDestroy : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Door"))
        {
            Destroy(collision.gameObject);
            print("Destroyed");
        }
    }

   
}
