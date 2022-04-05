using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NieblaChange : MonoBehaviour
{
    int maxVectors;
    int numrandom = 0;
    int lastPos = -1;
    GameObject currentDestination;
    public GameObject endPrefab;
    float contador;
    public float contador1;
    public Transform[] posNiebla;
    // Start is called before the first frame update
    void Start()
    {
        maxVectors = 2;
        contador = 0;
        ChangeNiebla();
    }

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
        if (contador >= contador1)
        {
            ChangeNiebla();
            contador = 0;
        }
    }
    void ChangeNiebla()
    {
        maxVectors = posNiebla.Length;
        numrandom = Random.Range(0, maxVectors);
        if (numrandom == lastPos && numrandom < maxVectors / 2)
        {
            numrandom += 1;
        }
        else if (numrandom == lastPos && numrandom > maxVectors / 2)
        {
            numrandom -= 1;
        }
        transform.position = posNiebla[numrandom].position;
    }
}
