using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
                
    public bool PadActive = false;
    public bool PadPress = false;

    //AudioSource AS;
    private void Start()
    {
        //AS = GetComponent<AudioSource>();
    }


   
     IEnumerator ButtonPress()
    {
        PadActive = true;
        //AS.Play();
        Vector3 targetPos = transform.position - new Vector3(0, 2f, 0);

        while(transform.position != targetPos)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPos, 2f * Time.deltaTime);
                yield return new WaitForEndOfFrame();
            }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            PadPress = true;            
            if (!PadActive)
            {
                StartCoroutine(ButtonPress());
                PS.Play();
            }
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            PadPress = false;
        }
    }

    
}
