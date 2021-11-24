using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenWithSwitchHori : MonoBehaviour
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
            gameObject.SetActive(false);
            AS.Play();

        }
    }
}
