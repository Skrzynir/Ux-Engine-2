using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneChange : MonoBehaviour

{
    int i = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(i+1);
    }

}
