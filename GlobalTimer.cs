using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay01;
    public GameObject timeDisplay02;
    public bool isTakingTime = false;
    public int timeLeft = 150;
    public static int timeScore;

    public GameObject timesUp;
    public GameObject levelAudio;
    public GameObject fadeOut;


    void Update()
    {
        timeScore = timeLeft;

        if (!isTakingTime)
        {
            StartCoroutine(SubtractSecond());
        }
        if (timeLeft == 0)
        {
            StartCoroutine(TimeIsUp());   
        }
    }

    IEnumerator SubtractSecond ()
    {
        if (timeLeft > 0)
        {
            isTakingTime = true;
            timeLeft -= 1;
            timeDisplay01.GetComponent<Text>().text = "" + timeLeft;
            timeDisplay02.GetComponent<Text>().text = "" + timeLeft;
            yield return new WaitForSeconds(1);
            isTakingTime = false;
        }
    }

    IEnumerator TimeIsUp()
    {
        //turn off level audio
        levelAudio.SetActive(false);

        //set death screen anim to active
        timesUp.SetActive(true);

        //wait 2 seconds and fade to black anim
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);

        //wait 1 second then set both anims back to inactive and reload scene
        yield return new WaitForSeconds(1);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel); // load level

        yield return new WaitForSeconds(1);
        timesUp.SetActive(false);
        fadeOut.SetActive(false);
    }
}
