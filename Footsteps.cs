using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    [SerializeField]
    private AudioClip clip;

    private AudioSource footstep;

    private void Awake()
    {
        footstep = GetComponent<AudioSource>();
    }

    private void Step()
    {
        if (PlayerController.playerGrounded)
        {
            footstep.PlayOneShot(clip);
        }
    }
}
