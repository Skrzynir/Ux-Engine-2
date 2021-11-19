using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenWithPressurePad : MonoBehaviour
{
    public GameObject PressurePad;
    PressurePad active;


    void Start()
    {
        active = PressurePad.GetComponent<PressurePad>();
    }

    
    void Update()
    {
        if (active.PadActive == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 10 * Time.deltaTime, 0);

        }

        if (active.PadActive == false)
        {
            //transform.position = new Vector3(transform.position.x, 1, 0);
        }
    }


}
