using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    Animator anim;
    public Transform PlayerCam;
    public float TransitionSpeed = 10;
    bool isTransitioning;
    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    void Update()
    {
        if(!isTransitioning && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        {
            isTransitioning = true;
            StartCoroutine(Transition());
            anim.enabled = false;
        }
    }

    IEnumerator Transition()
    {
        while (transform.position != PlayerCam.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, PlayerCam.position, TransitionSpeed * Time.deltaTime * 15);
            yield return new WaitForEndOfFrame();
        }
        gameObject.SetActive(false);
    }
}
