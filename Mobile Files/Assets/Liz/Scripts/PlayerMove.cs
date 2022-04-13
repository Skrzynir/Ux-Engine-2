using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10;
    
    public bool isJumping = false;
    public float jumpHeight = 7f;

    public float smooth = 0.5f;

    public Rigidbody2D PlayerRb;


    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        
        Vector3 move = new Vector3(horizontal, 0, 0);

        gameObject.transform.position += move * Time.deltaTime * speed;

        if (Input.GetKeyDown(KeyCode.W) && isJumping == false)
        {
            PlayerRb.velocity = new Vector2(PlayerRb.velocity.x, 0);
            PlayerRb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode2D.Impulse);
        }


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
