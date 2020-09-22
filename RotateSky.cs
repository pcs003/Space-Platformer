using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    public float rotateSpeed = 1.2f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
    }
}
