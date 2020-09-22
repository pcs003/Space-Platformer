using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Level002 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        RedirectToLevel.redirectToLevel = 5;
        RedirectToLevel.nextLevel = 6;
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
