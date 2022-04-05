using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Controller : MonoBehaviour
{
    public Text contador;

    public Player_Controller a;

    public int vida = 3;

    void Start()
    {
        a = FindObjectOfType<Player_Controller>();

        contador.text = "VIDAS : " + a.health;
    }

    void Update()
    {
        contador.text = "VIDAS : " + a.health.ToString("f0");
    }
}
