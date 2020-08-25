using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Darragh Dowling Dec/2018

public class KillTimerText : MonoBehaviour {

    public float time = 10; 

    void Start () {

        Destroy(gameObject, time);

	}

}
