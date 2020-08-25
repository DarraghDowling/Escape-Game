using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Darragh Dowling Dec/2018

public class Timer : MonoBehaviour {
    [SerializeField] private Text uitext;
    [SerializeField] private float mainTimer;
    [SerializeField] private AudioSource Explosion;
    [SerializeField] private string loadLevel;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;

    public GameObject EndGame;

    void Start()
    {
        timer = mainTimer;
    }

    void Update()
    {
        if(timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uitext.text = timer.ToString("F");
        }

        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uitext.text = "0.00";
            timer = 0.0f;
            Explosion.Play();
            EndGame.SetActive(true);
            StartCoroutine(waitEnd());

        }
    }

    IEnumerator waitEnd()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(loadLevel);
    }

}
