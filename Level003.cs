using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Level003 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        RedirectToLevel.redirectToLevel = 6;
        RedirectToLevel.nextLevel = 7;
        StartCoroutine(FadeInOff());
        PlayerController.inputEnabled = true;
        LevelDeath.falling = false;
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
