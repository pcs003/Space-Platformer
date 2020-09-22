using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CascadeSquares : MonoBehaviour
{
    public int numTriplets = 5;
    public GameObject triplet1a;
    public GameObject triplet1b;
    public GameObject triplet1c;
    public GameObject triplet2a;
    public GameObject triplet2b;
    public GameObject triplet2c;
    public GameObject triplet3a;
    public GameObject triplet3b;
    public GameObject triplet3c;
    public GameObject triplet4a;
    public GameObject triplet4b;
    public GameObject triplet4c;
    public GameObject triplet5a;
    public GameObject triplet5b;
    public GameObject triplet5c;

    void Start()
    {
        triplet1a.GetComponent<Animator>().enabled = false;
        triplet1b.GetComponent<Animator>().enabled = false;
        triplet1c.GetComponent<Animator>().enabled = false;

        triplet2a.GetComponent<Animator>().enabled = false;
        triplet2b.GetComponent<Animator>().enabled = false;
        triplet2c.GetComponent<Animator>().enabled = false;

        triplet3a.GetComponent<Animator>().enabled = false;
        triplet3b.GetComponent<Animator>().enabled = false;
        triplet3c.GetComponent<Animator>().enabled = false;

        triplet4a.GetComponent<Animator>().enabled = false;
        triplet4b.GetComponent<Animator>().enabled = false;
        triplet4c.GetComponent<Animator>().enabled = false;

        triplet5a.GetComponent<Animator>().enabled = false;
        triplet5b.GetComponent<Animator>().enabled = false;
        triplet5c.GetComponent<Animator>().enabled = false;

    }

    void Update()
    {
        StartCoroutine(Cascade());
    }

    IEnumerator Cascade()
    {
        triplet1a.GetComponent<Animator>().enabled = true;
        triplet1b.GetComponent<Animator>().enabled = true;
        triplet1c.GetComponent<Animator>().enabled = true;

        yield return new WaitForSeconds(3);

        triplet2a.GetComponent<Animator>().enabled = true;
        triplet2b.GetComponent<Animator>().enabled = true;
        triplet2c.GetComponent<Animator>().enabled = true;

        yield return new WaitForSeconds(3);

        triplet3a.GetComponent<Animator>().enabled = true;
        triplet3b.GetComponent<Animator>().enabled = true;
        triplet3c.GetComponent<Animator>().enabled = true;

        yield return new WaitForSeconds(3);

        triplet4a.GetComponent<Animator>().enabled = true;
        triplet4b.GetComponent<Animator>().enabled = true;
        triplet4c.GetComponent<Animator>().enabled = true;

        yield return new WaitForSeconds(3);

        triplet5a.GetComponent<Animator>().enabled = true;
        triplet5b.GetComponent<Animator>().enabled = true;
        triplet5c.GetComponent<Animator>().enabled = true;
    }
}
