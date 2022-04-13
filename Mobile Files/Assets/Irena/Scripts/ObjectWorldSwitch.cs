using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWorldSwitch : MonoBehaviour
{
    float JumpPosition = 50;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (this.transform.position.z == JumpPosition)
            {
                this.transform.position -= new Vector3(0, 0, JumpPosition);


            }

            else
            {
                this.transform.position += new Vector3(0, 0, JumpPosition);
            }

            print("Q pressed");

        }

    }
}
