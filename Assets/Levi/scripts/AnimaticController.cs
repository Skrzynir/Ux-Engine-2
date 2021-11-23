using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AnimaticController : MonoBehaviour
{
    int Frame = 0;
    public Sprite[] Sprites;
    Image IMG;
    void NextFrame()
    {
        Frame++;
        if(Frame == Sprites.Length)
        {
            int targetScene = SceneManager.GetActiveScene().buildIndex + 1;
            if(targetScene<SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(targetScene);
            }
            else
            {
                SceneManager.LoadScene(0);
            }   
            return;
        }
        IMG.sprite = Sprites[Frame];
    }
    void Start()
    {
        IMG = GetComponent<Image>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Submit"))
        {
            NextFrame();
        }
    }
}
