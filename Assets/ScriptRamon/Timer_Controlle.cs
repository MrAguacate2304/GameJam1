using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_Controlle : MonoBehaviour
{
    public Text contador;
    private float time = 20f;
    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + time;
    }

    // Update is called once per frame
    void Update()
    {
        if (time == 0f)
        {
            time = 20f;
        }

        if (time >= 0 )
        {
            time -= Time.deltaTime;
            contador.text = " " + time.ToString("f0");
        }
        else if (time < 1)
        {
            time = 0;
            contador.text = " " + time.ToString("f0");
        }
    }
}
