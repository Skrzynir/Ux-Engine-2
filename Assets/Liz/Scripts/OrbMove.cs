using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbMove : MonoBehaviour
{
    public bool floatUp = false;
    public 


    // Start is called before the first frame update
    void Start()
    {
        floatUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (floatUp == true)
        {
            StartCoroutine(floatingUp());
        }
        if (floatUp == false)
        {
            StartCoroutine(floatingDown());
        }
    }

    public IEnumerator floatingUp()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f * Time.deltaTime, 0);
        yield return new WaitForSeconds(0.75f);
        floatUp = false;
    }

    public IEnumerator floatingDown()
    {
        transform.position = new Vector3 (transform.position.x, transform.position.y - 0.5f * Time.deltaTime, 0);
        yield return new WaitForSeconds(0.75f);
        floatUp = true;
    }
}
