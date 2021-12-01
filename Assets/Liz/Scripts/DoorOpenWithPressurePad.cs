using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenWithPressurePad : MonoBehaviour
{
    public GameObject PressurePad;
    PressurePad active;

    [SerializeField]
    public AudioSource source;
    public AudioClip dooropen;
    public AudioClip doorshut;

    void Start()
    {
        active = PressurePad.GetComponent<PressurePad>();        
    }


    void Update()
    {
        if (active.PadActive == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 10 * Time.deltaTime, 0);
            source.PlayOneShot(dooropen);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {        
        if (collision.gameObject.tag == "Player")
        {
            source.PlayOneShot(doorshut);
        }
    }
}
