using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public bool isPaused;
    public GameObject PauseMenu;

    //new input
    PlayerInput playerInput;

    void Start()
    {
        PauseMenu.SetActive(false);
        //new input
        playerInput = new PlayerInput();
        playerInput.PlayerMap.Pause.performed += c => TogglePause();
        playerInput.Enable();

    }

    // void Update()
    // {
    //     if (Input.GetButtonDown("Cancel"))
    //         TogglePause();
    // }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0f : 1f;
        PauseMenu.SetActive(isPaused);
    }

}
