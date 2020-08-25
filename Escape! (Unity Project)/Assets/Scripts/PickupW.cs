using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Darragh Dowling Dec/2018

public class PickupW : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject PickupText;
    [SerializeField] private GameObject AlreadyHave;
    [SerializeField] private AudioSource GetKey;
    public float time = 1;

    public void OnMouseOver()
    {
        PickupText.SetActive(true);
        if (player.CompareTag("CorrectKey")){
            AlreadyHave.SetActive(true);

        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            player.tag = "WrongKey";
            GetKey.Play();
            gameObject.SetActive(false);
            PickupText.SetActive(false);
            Destroy(gameObject);
        }
    }

    public void OnMouseExit()
    {
        PickupText.SetActive(false);
        AlreadyHave.SetActive(false);
    }
}
