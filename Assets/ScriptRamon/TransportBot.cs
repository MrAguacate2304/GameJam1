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
    float contador;
    public float contador1;
    public Transform[] posicionBot;
    

    // Start is called before the first frame update
    void Start()
    {
        maxVectors = 2;
        posBot = new Vector2[maxVectors];
        //posBot[0] = new Vector2(7.35f, 2.44f);
        //posBot[1] = new Vector2(-6.6f, 2.74f);
        contador = 0;
        transportBot();
    }

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
        if (contador >= contador1)
        {
            transportBot();
            contador = 0;
        }
    }

    void transportBot() 
    {
        maxVectors = posicionBot.Length;
        numrandom = Random.Range(0, maxVectors);
            if (numrandom == lastPos && numrandom < maxVectors / 2)
            {
                numrandom += 1;
            }
            else if (numrandom == lastPos && numrandom > maxVectors / 2)
            {
                numrandom -= 1;
            }
            transform.position = posicionBot[numrandom].position;      
    }
}
