using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class GemRotate : MonoBehaviour
{
    public int rotateSpeed = 2;


    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.timeScale, 0, Space.World);
    }
}
