using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenWithSwitch : MonoBehaviour
{
    public GameObject SwitchObject;
    Switch press;

    
    void Start()
    {
        press = SwitchObject.GetComponent<Switch>();
    }

    
    void Update()
    {
        if (press.SwitchActive == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 10 * Time.deltaTime, 0);
        }
    }
}
