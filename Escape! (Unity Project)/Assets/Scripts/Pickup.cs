using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Darragh Dowling Dec/2018

public class Pickup : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject PickupText;
    [SerializeField] private AudioSource KeyGet;
    public float time = 1;

    public void OnMouseOver()
    {
        PickupText.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            player.tag = "CorrectKey";
            KeyGet.Play();
            gameObject.SetActive(false);
            PickupText.SetActive(false);
            Destroy(gameObject);
        }
    }

    public void OnMouseExit()
    {
        PickupText.SetActive(false);
    }
}
