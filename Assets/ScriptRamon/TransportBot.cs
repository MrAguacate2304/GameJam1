using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransportBot : MonoBehaviour
{
    int maxVectors;
    Vector2[] posBot;
    int numrandom = 0;
    int lastPos = -1;
    GameObject currentDestination;
    public GameObject endPrefab;

    // Start is called before the first frame update
    void Start()
    {
        maxVectors = 3;
        posBot = new Vector2[maxVectors];
        posBot[0] = new Vector2(7.35f, 2.44f);
        posBot[1] = new Vector2(-6.6f, 2.74f);
    }

    // Update is called once per frame
    void Update()
    {
        //numrandom = Random.Range(0, maxVectors);
        //if (numrandom == lastPos && numrandom < maxVectors / 2)
        //{
        //    numrandom += 1;
        //}
        //else if (numrandom == lastPos && numrandom > maxVectors / 2)
        //{
        //    numrandom -= 1;
        //}
        //currentDestination = Instantiate(endPrefab, posBot[numrandom], Quaternion.identity);

    }
}
