using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSwitch : MonoBehaviour
{
    public GameObject player;

    SpriteRenderer SR;

    float ColourJump = 50;

    ObjectWorldSwitch OWS;



    // Start is called before the first frame update
    void Start()
    {

        SR = GetComponent<SpriteRenderer>();
        OWS = GetComponent<ObjectWorldSwitch>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (player.transform.position.z == ColourJump)
            {
                player.transform.position -= new Vector3(0, 0, ColourJump);
                SR.color = Color.black;
                
            }

            else
            {
                player.transform.position += new Vector3(0, 0, ColourJump);
                SR.color = Color.red;
            }

            print("E pressed");

            
        }
      

    }

  
}
