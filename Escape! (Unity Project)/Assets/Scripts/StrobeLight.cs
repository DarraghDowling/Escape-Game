using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Darragh Dowling Dec/2018

public class StrobeLight : MonoBehaviour {

    Light testLight;

    void Start()
    {
        testLight = GetComponent<Light>();
        StartCoroutine(Strobe());
    }

    IEnumerator Strobe()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            testLight.enabled = !testLight.enabled;
        }
    }
}
