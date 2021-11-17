using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public float smooth = 0.5f;
       
    void Update()
    {
        transform.position = new Vector3(player.position.x -5, player.position.y +5, transform.position.z);
    }
}
