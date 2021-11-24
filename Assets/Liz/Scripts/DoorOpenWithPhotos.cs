using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenWithPhotos : MonoBehaviour
{
    public GameObject player;
    //PhotoCheck photo;
    PhotoUIDisplay pho;
    

    public bool ColAll = false;


    void Start()
    {
        //photo = player.GetComponent<PhotoCheck>();
        pho = GetComponent<PhotoUIDisplay>();
        
    }

    void Update()
    {
        if (pho.yellowP.enabled == true && pho.redP.enabled == true && pho.blueP.enabled == true)
        {
            ColAll = true;
        }
    }
        
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && ColAll == true)
        {
            Debug.Log("doorshouldopen");
        }
    }
}
