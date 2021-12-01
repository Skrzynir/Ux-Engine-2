using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PhotoPickUp : MonoBehaviour
{
    public GameObject photoPrefab;
    public GameObject PhotoGroup;
    public static int NumPhotosCollected;
    public bool pass;
    [SerializeField]
    public AudioSource source;
    public AudioClip orbget;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && pass == true)
        {
            SpriteRenderer img = GetComponent<SpriteRenderer>();
            GameObject newPhoto = Instantiate(photoPrefab, Vector3.zero, Quaternion.identity, PhotoGroup.transform);
            newPhoto.GetComponent<Image>().sprite = img.sprite;
            NumPhotosCollected++;
            Destroy(gameObject);
            source.PlayOneShot(orbget);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            pass = true;            
        }
    }
}
