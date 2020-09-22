using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemGreen : MonoBehaviour
{

    public GameObject ScoreBox;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            GlobalScore.currentScore += 2000;
            collectSound.Play();
            Destroy(gameObject);
        }
    }

}
