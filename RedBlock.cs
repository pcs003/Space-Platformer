using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RedBlock : MonoBehaviour
{

    void Start()
    {
        transform.parent.GetComponent<Rigidbody>().useGravity = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            StartCoroutine(Fall());
        }
    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(1);
        transform.parent.GetComponent<Rigidbody>().useGravity = true;
    }
}
