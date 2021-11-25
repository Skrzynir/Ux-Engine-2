using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenWithPhotos : MonoBehaviour
{
    int _requiredNumPhotos = 3;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(PhotoPickUp.NumPhotosCollected>= _requiredNumPhotos)
            {
                Debug.Log("doorshouldopen");
            }
        }
    }
}
