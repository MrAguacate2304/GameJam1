using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaSpawner : MonoBehaviour
{
    float timer;
    public GameObject monedaPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >=2f)
        {
            timer = 0;
            Instantiate(monedaPrefab);
        }
    }
}
