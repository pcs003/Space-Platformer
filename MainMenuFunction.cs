using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;

    IEnumerator PlayEnum()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 3;
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene(2);
    }

    IEnumerator RollCredits()
    {
        buttonPress.Play();
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene(3);
    }

    public void PlayGame()
    {
        StartCoroutine(PlayEnum());
    }

    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();
    }

    public void ViewCredits()
    {
        StartCoroutine(RollCredits());
    }
}
