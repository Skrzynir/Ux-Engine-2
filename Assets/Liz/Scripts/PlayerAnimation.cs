using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public SpriteRenderer CharSR;

    public Sprite Front;
    public Sprite Left;
    public Sprite Right;
    public Sprite Jump;
    public Sprite Land;


    void Start()
    {
        CharSR = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        //Right
        if (Input.GetKeyDown(KeyCode.D))
        {
            CharSR.sprite = Right;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            CharSR.sprite = Front;
        }
        //Left
        if (Input.GetKeyDown(KeyCode.A))
        {
            CharSR.sprite = Left;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            CharSR.sprite = Front;
        }
        
    }

    //Jump
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            CharSR.sprite = Land;            
        }
    }

    //Land
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            CharSR.sprite = Jump;
        }
    }
}
