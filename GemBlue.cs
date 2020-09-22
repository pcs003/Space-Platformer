using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemBlue : MonoBehaviour
{

    public GameObject ScoreBox;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            GlobalScore.currentScore += 5000;
            collectSound.Play();
            Destroy(gameObject);
        }
    }

}
