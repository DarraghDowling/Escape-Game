using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Darragh Dowling Dec/2018

public class MenuItems: MonoBehaviour {

    public void LoadLevel(int ChangeScene)
    {
        SceneManager.LoadScene(ChangeScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
