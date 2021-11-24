using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public bool isPaused;
    public GameObject PauseMenu;

    void Start()
    {
        PauseMenu.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
            TogglePause();
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0f : 1f;
        PauseMenu.SetActive(isPaused);
    }
}
