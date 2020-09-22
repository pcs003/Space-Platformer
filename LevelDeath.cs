using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject youFell;
    public GameObject levelAudio;
    public GameObject fadeOut;

    public static bool falling = false;

    void Start()
    {
        youFell.SetActive(false);
        fadeOut.SetActive(false);
    }
    void OnTriggerEnter( Collider col )
    {
        if (col.tag == "Player")
        {
            StartCoroutine(YouFellOff());
        }
    }

    IEnumerator YouFellOff ()
    {
        //turn off level audio
        levelAudio.SetActive(false);

        //set death screen anim to active
        falling = true;
        youFell.SetActive(true);
        

        //wait 2 seconds and fade to black anim
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);

        //wait 1 second then set both anims back to inactive and reload scene
        yield return new WaitForSeconds(1);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel); // load level

        yield return new WaitForSeconds(1);
        youFell.SetActive(false);
        fadeOut.SetActive(false);
        falling = false;
    }
}
