using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenWithSwitchHori : MonoBehaviour
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
            gameObject.SetActive(false);

        }
    }
}
