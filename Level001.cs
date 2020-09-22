using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Level001 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        RedirectToLevel.redirectToLevel = 4;
        RedirectToLevel.nextLevel = 5;
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
