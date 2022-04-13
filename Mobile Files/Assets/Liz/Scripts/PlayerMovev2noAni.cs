using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovev2noAni : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 300f;

    private float moveHori;
    private float moveVert;
    private Vector2 currVelo;

    public bool isJumping = false;
    public bool isGrounded = true;

    public Rigidbody2D PlayerRb;


    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        moveHori = Input.GetAxis("Horizontal");
        moveVert = Input.GetAxis("Vertical");
        currVelo = PlayerRb.velocity;

        isJumping = false;
        isGrounded = true;


        if (Input.GetKeyDown(KeyCode.W) && !isJumping)
        {
            PlayerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);
            isJumping = true;
            isGrounded = false;            
        }


        if (moveHori != 0)
        {
            PlayerRb.velocity = new Vector2(moveHori * speed, currVelo.y);
        }
       
       
    }
   

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            isJumping = false;
            isGrounded = true;
        }
        else
        {
            isGrounded = false;            
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            isJumping = true;
            isGrounded = false;
        }
    }

}
