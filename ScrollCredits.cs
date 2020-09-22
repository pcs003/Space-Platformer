using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollCredits : MonoBehaviour
{
    public GameObject credits;

    void Start()
    {
        StartCoroutine(RollCredits());
    }

    IEnumerator RollCredits()
    {
        yield return new WaitForSeconds(0.5f);
        credits.SetActive(true);
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene(1);
    }
}
