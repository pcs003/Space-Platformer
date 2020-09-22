using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool isPaused = false;
    public AudioSource levelMusic;
    public AudioSource pauseSound;
    public GameObject pauseMenu;
    public GameObject fadeOut;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (!isPaused)
            {
                pauseSound.Play();
                Time.timeScale = 0;
                isPaused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                pauseMenu.SetActive(true);
            } else
            {
                pauseMenu.SetActive(false);
                Cursor.visible = false;
                isPaused = false;
                levelMusic.UnPause();
                Time.timeScale = 1;
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Cursor.visible = false;
        isPaused = false;
        levelMusic.UnPause();
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        fadeOut.SetActive(true);
        pauseMenu.SetActive(false);
        Cursor.visible = false;
        isPaused = false;
        levelMusic.UnPause();
        Time.timeScale = 1;
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
        GlobalScore.currentScore = 0;
    }

    public void QuitToMenu()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
        levelMusic.UnPause();
        Time.timeScale = 1;
        fadeOut.SetActive(true);
        SceneManager.LoadScene(1);
    }
}
