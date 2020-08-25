using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Darragh Dowling Dec/2018

public class PauseMenu : MonoBehaviour {

    public static bool PauseGame = false;
    public GameObject PauseMenuUI;

void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Resume();
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                Pause();
            }
        }

    }

public void Resume ()
        {
            PauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            PauseGame = false;
        }

void Pause ()
        {
            PauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            PauseGame = true;
        }

public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
