using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemSilver : MonoBehaviour
{

    public GameObject ScoreBox;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            GlobalScore.currentScore += 1000;
            collectSound.Play();
            Destroy(gameObject);
        }
    }

}
