using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenWithPhotos : MonoBehaviour
{
    public int _requiredNumPhotos = 3;
    public GameObject part;
    [SerializeField]
    public AudioSource source;
    public AudioClip dooropen;
    public AudioClip doorshut;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(PhotoPickUp.NumPhotosCollected == _requiredNumPhotos)
            {                
                Instantiate(part, transform.position, transform.rotation);
                Destroy(gameObject);
                source.PlayOneShot(dooropen);
            }
            if (PhotoPickUp.NumPhotosCollected != _requiredNumPhotos)
            {
                source.PlayOneShot(doorshut);
            }
        }
    }
}
