using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveVer2 : MonoBehaviour
{
    public float speed = 10f;
    public float JumpSpeed = 2f;

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

    public ParticleSystem JumpLandPS;
   
   PlayerInput playerInput;

    void Start()
    {
        playerInput=new PlayerInput();
        playerInput.PlayerMap.Jump.performed+= c=> Jump();
        playerInput.Enable();
        
        PlayerRb = GetComponent<Rigidbody2D>();
        Ani = GetComponent<Animator>();
        SR = GetComponent<SpriteRenderer>();   
    }

    void Update()
    {
        moveHori = playerInput.PlayerMap.Move.ReadValue<float>();
        //moveVert = Input.GetAxis("Vertical");
        currVelo = PlayerRb.velocity;
        JumpLandPS.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 3, -2);

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
        if (numOfJumps > 0)
        {
        BeginAirborne();
        Ani.SetBool("IsJumping", true);
        numOfJumps--;
        PlayerRb.velocity = new Vector2(PlayerRb.velocity.x,JumpSpeed);
        }
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
            JumpLandPS.Play();
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
