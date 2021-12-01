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


    private void Start()
    {
        SR = GetComponent<SpriteRenderer>();       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && SwitchToPress == true)
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
