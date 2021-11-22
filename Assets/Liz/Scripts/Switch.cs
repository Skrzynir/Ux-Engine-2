using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool SwitchToPress = false;
    public bool SwitchActive = false;

    public SpriteRenderer switchSR;
    public Sprite normal;
    public Sprite used;

    private void Start()
    {
        switchSR = GetComponent<SpriteRenderer>();
        switchSR.sprite = normal;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && SwitchToPress == true)
        {
            SwitchActive = true;
            switchSR.sprite = used;
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
