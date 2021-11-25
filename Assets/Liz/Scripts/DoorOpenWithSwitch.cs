using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenWithSwitch : MonoBehaviour
{
    public GameObject SwitchObject;
    Switch press;
    AudioSource AS;

    
    void Start()
    {
        press = SwitchObject.GetComponent<Switch>();
        AS = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (press.SwitchActive == true)
        {

            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y + 10 * Time.deltaTime, -200, 200), 0);

        }

    }

   
  
}
