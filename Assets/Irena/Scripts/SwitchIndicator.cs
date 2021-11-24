using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchIndicator : MonoBehaviour
{
    public GameObject Indicator;
    public GameObject player;

    Switch SwitchS;
    Renderer RD;
    SpriteRenderer SR;

    private void Start()
    {
        RD = GetComponent<Renderer>();
        SwitchS = GetComponent<Switch>();
        SR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        if (RD.isVisible == false)
        {

            Debug.Log("Object isn't visible ");
            if (Indicator.activeSelf == false)
            {
                Indicator.SetActive(true);

            }

            Vector2 direction = player.transform.position - transform.position;

            RaycastHit2D ray = Physics2D.Raycast(transform.position, direction);

            if (ray.collider != null)
            {
                Indicator.transform.position = ray.point;
                Debug.Log("Banana sauce");
            }

        }
        else
        {
            if (Indicator.activeSelf == true)
            {
                Indicator.SetActive(false);
            }
        }
        if (SwitchS.SwitchActive == true)
        {

        }

    }

    /*private void OnBecameInvisible()
    {
        Debug.Log("Object isn't visible ");
        if (Indicator.activeSelf == false)
        {
            Indicator.SetActive(true);

        }

        Vector2 direction = player.transform.position - transform.position;

        RaycastHit2D ray = Physics2D.Raycast(transform.position, direction);

        if (ray.collider != null)
        {
            Indicator.transform.position = ray.point;
            Debug.Log("Banana sauce");
        }
        else
        {
            if (Indicator.activeSelf == true)
            {
                Indicator.SetActive(false);
            }
        }
        if (SwitchS.SwitchActive == true)
        {

        }

    }*/
}
