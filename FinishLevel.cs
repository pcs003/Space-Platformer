using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject congrats;
    public GameObject timeLeft;
    public GameObject score;
    public GameObject totalScore;
    public int timeCalc;
    public int scoreCalc;
    public int totalScoreCalc;
    public GameObject levelBlocker;
    public GameObject fadeOut;
        
    
    void OnTriggerEnter()
    {
        //levelBlocker.SetActive(true);
        //levelBlocker.transform.parent = null;

        timeCalc = GlobalTimer.timeScore * 100;
        totalScoreCalc = timeCalc + GlobalScore.currentScore;
        string levelScoreName = "Level" + (RedirectToLevel.redirectToLevel - 3).ToString() + "Highscore";
        if (PlayerPrefs.GetInt(levelScoreName) < totalScoreCalc)
        {
            PlayerPrefs.SetInt(levelScoreName, totalScoreCalc);
        }
        

        timeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.timeScore + " x 100";
        score.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScoreCalc;

        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());

        GetComponent<BoxCollider>().enabled = false;
        PlayerController.inputEnabled = false;
    }

    IEnumerator CalculateScore()
    {
        congrats.SetActive(true);
        yield return new WaitForSeconds(2);
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(1);
        score.SetActive(true);
        yield return new WaitForSeconds(1);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.nextLevel);
    }
}
