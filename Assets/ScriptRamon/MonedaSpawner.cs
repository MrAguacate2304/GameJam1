using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaSpawner : MonoBehaviour
{
    float timer;
    public GameObject monedaPrefab;
    void Update(){
        timer += Time.deltaTime;
        if (timer >= 10f)
        {
            timer = 0;
            float x = Random.Range(-6, 5);
            float y = Random.Range(-1, 4.5f);
            Vector3 position = new Vector3(x, y, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(monedaPrefab, position, rotation);
        }
    }
}
