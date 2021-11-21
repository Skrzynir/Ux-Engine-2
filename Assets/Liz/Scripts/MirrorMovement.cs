using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorMovement : MonoBehaviour
{
    public Transform OriginalVersion;

    
    
    void Update()
    {
        transform.position = new Vector3(OriginalVersion.position.x, transform.position.y, 0);
    }
}
