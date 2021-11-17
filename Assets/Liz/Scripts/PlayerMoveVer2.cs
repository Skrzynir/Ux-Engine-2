using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveVer2 : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 300f;

    private float moveHori;
    private float moveVert;
    private Vector2 currVelo;

   
    int numOfJumps = 1;
    public int MaxNumOfJumps = 1;
    bool isAirborne = false;
    public PhysicsMaterial2D GroundedMat;
    public PhysicsMaterial2D AirborneMat;

    public Rigidbody2D PlayerRb;

    //Animation Variables
    public Animator Ani;
    public SpriteRenderer SR;
   

    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
        Ani = GetComponent<Animator>();
        SR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        moveHori = Input.GetAxis("Horizontal");
        moveVert = Input.GetAxis("Vertical");
        currVelo = PlayerRb.velocity;




        if (Input.GetKeyDown(KeyCode.W))
        {
            if (numOfJumps > 0)
            {
                Jump();
                BeginAirborne();
                Ani.SetBool("IsJumping", true);
            }
        }

        PlayerRb.velocity = new Vector2(moveHori * speed, currVelo.y);

        Ani.SetFloat("Speed", Mathf.Abs(moveHori));

        if (moveHori > 0.01f)
        {
            gameObject.transform.localScale = new Vector3(-0.8f, 0.8f, -0.8f);
        }
        else
        {
            gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        }
    }

    void Jump()
    {
        numOfJumps--;
        PlayerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);
    }

    void BeginAirborne()
    {
        isAirborne = true;
        PlayerRb.sharedMaterial = AirborneMat;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Platform")
        {
            PlayerRb.sharedMaterial = GroundedMat;
            isAirborne = false;
            numOfJumps = MaxNumOfJumps;
            Ani.SetBool("IsJumping", false);
        }

        if (collider.tag == "Box")
        {
            PlayerRb.sharedMaterial = GroundedMat;
            isAirborne = false;
            numOfJumps = MaxNumOfJumps;
            Ani.SetBool("IsJumping", false);
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        BeginAirborne();
        numOfJumps = MaxNumOfJumps - 1;
    }
}
