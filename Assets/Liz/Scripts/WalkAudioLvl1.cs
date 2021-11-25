using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAudioLvl1 : MonoBehaviour
{
    [SerializeField]
    public AudioClip realSteps;
    public AudioClip dreamSteps;

    public AudioSource source;

    public GameObject player;
    public float worldSplit;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (player.transform.position.x <= worldSplit)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                source.PlayOneShot(realSteps);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                source.Stop();
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                source.PlayOneShot(realSteps);
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                source.Stop();
            }
        }
        if (player.transform.position.x >= worldSplit)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                source.PlayOneShot(dreamSteps);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                source.Stop();
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                source.PlayOneShot(dreamSteps);
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                source.Stop();
            }
        }
    }
}
