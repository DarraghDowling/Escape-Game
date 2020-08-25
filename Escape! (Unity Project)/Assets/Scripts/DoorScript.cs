using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Darragh Dowling Dec/2018

public class DoorScript : MonoBehaviour {

    Animator anim;
    public AudioSource doorLock;
    public GameObject NoKey;
    public GameObject WrongKey;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CorrectKey"))
        {
            anim.SetTrigger("Open Door");
        }
        else if (other.CompareTag("NoKey"))
        {
            doorLock.Play();
            NoKey.SetActive(true);
        }
        else if (other.CompareTag("WrongKey"))
        {
            doorLock.Play();
            WrongKey.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CorrectKey"))
        {
            anim.enabled = true;
        }
        else if (other.CompareTag("NoKey"))
        {
            NoKey.SetActive(false);
        }
        else if (other.CompareTag("WrongKey"))
        {
            WrongKey.SetActive(false);
        }
    }

    void AnimPause()
    {
        anim.enabled = false;
    }
}
