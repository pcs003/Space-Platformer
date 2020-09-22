using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    public GameObject theLogo;
    public AudioSource logoSound;

    void Start()
    {
        StartCoroutine(RunSplash());
    }

    IEnumerator RunSplash ()
    {
        yield return new WaitForSeconds(0.5f);
        theLogo.SetActive(true);
        logoSound.Play();
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(1);
    }
}
