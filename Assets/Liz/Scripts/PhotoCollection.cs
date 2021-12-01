using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoCollection : MonoBehaviour
{
    public GameObject player;
    public bool pass = false;
    PhotoCheck photo;
    public bool collect = false;


    void Start()
    {
        photo = player.GetComponent<PhotoCheck>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && pass == true)
        {            
            collect = true;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pass = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pass = false;
    }
}
