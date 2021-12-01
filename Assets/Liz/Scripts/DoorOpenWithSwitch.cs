using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenWithSwitch : MonoBehaviour
{
    public GameObject SwitchObject;
    Switch press;
    [SerializeField]
    public AudioSource source;
    public AudioClip dooropen;
    public AudioClip doorshut;


    void Start()
    {
        press = SwitchObject.GetComponent<Switch>();        
    }

    
    void Update()
    {
        if (press.SwitchActive == true)
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y + 10 * Time.deltaTime, -200, 200), 0);
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
