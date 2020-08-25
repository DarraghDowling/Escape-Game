using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Darragh Dowling Dec/2018

public class WinBox : MonoBehaviour
{
    [SerializeField]private string loadLevel;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CorrectKey"))
        {
            SceneManager.LoadScene(loadLevel);
        }
    }

}
