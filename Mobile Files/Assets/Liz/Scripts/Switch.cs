using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool SwitchToPress = false;
    public bool SwitchActive = false;
    

    SpriteRenderer SR;
    public Sprite GreySwitch;
    [SerializeField]
    public AudioSource source;
    public AudioClip switchacti;

    PlayerInput playerInput;


    private void Start()
    {
        playerInput = new PlayerInput();
        playerInput.PlayerMap.Activate.performed += c => Activate();
        playerInput.Enable();

        SR = GetComponent<SpriteRenderer>();       
    }

    public void Activate()
    {
        if (SwitchToPress == true)
        {
            SwitchActive = true;
            SR.sprite = GreySwitch;
            SR.flipY = true;
            source.PlayOneShot(switchacti);
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {            
            SwitchToPress = true;
        }
                
    }
}
