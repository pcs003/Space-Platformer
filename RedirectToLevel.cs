using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Globalization;

public class RedirectToLevel : MonoBehaviour
{
    public static int redirectToLevel;

    public static int nextLevel;

    public AudioSource buttonPress;

    public int[] bestScores;

    public Text highscoreText;

    public int numLevels = 4;

    public GameObject resetConfirmationObject;
    public GameObject fadeOut;


    public void SelectLevel(int levelNum)
    {
        StartCoroutine(FadeToLevel(levelNum));
    }

    public void ShowHighScore(int levelNum)
    {
        string scoreName = "Level" + levelNum.ToString() + "Highscore";
        highscoreText.text = "Level " + levelNum.ToString() + " Best Score: " + PlayerPrefs.GetInt(scoreName).ToString();
    }

    public void ClickedReset()
    {
        buttonPress.Play();
        resetConfirmationObject.SetActive(true);
    }

    public void ConfirmReset()
    {

        string scoreName = "";
        for (int i = 1; i <= numLevels; i++)
        {
            scoreName = "Level" + i.ToString() + "Highscore";
            PlayerPrefs.SetInt(scoreName, 0);
        }

        highscoreText.text = "Level 1 Best Score: 0";
        resetConfirmationObject.SetActive(false);
    }

    public void CancelReset()
    {
        resetConfirmationObject.SetActive(false);
    }

    public void ReturnToMain()
    {
        buttonPress.Play();
        SceneManager.LoadScene(1);
    }

    IEnumerator FadeToLevel(int levelNum)
    {
        buttonPress.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(levelNum + 3);
    }
}
