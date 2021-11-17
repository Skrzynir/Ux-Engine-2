using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveV3noAni : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 300f;

    private float moveHori;
    private float moveVert;
    private Vector2 currVelo;

    public bool isJumping = false;
    public bool hasJumped = false;

    public Rigidbody2D PlayerRb;
        


    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();       
    }

    void Update()
    {
        moveHori = Input.GetAxis("Horizontal");
        moveVert = Input.GetAxis("Vertical");
        currVelo = PlayerRb.velocity;

        isJumping = false;


        if (Input.GetKeyDown(KeyCode.W) && (isJumping == false))
        {
            PlayerRb.velocity = new Vector3(0, 10, 0);
            //PlayerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);
            isJumping = true;
        }


        if (moveHori != 0)
        {
            PlayerRb.velocity = new Vector2(moveHori * speed, currVelo.y);
        }
                    

       

       /* if (PlayerRb.velocity.y >= 0.5f)
        {
            hasJumped = true;
            isJumping = true;
        }
        else
        {
            hasJumped = false;
            isJumping = false;
        }*/


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            isJumping = false;           
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            isJumping = true;
        }
    }

}
