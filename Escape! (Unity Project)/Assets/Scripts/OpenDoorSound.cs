using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Darragh Dowling Dec/2018

public class OpenDoorSound : MonoBehaviour {

    public AudioSource doorUnLock;
    public GameObject UnlockSound;
    public float time = 2;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CorrectKey"))
        {
            doorUnLock.Play();
            Destroy(UnlockSound, time);
        }
    }

}
