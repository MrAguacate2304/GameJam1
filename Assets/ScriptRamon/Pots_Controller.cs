using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pots_Controller : MonoBehaviour
{
    public Text contador;

    public Player_Controller a;

    public int pots = 0;

    void Start()
    {
        a = FindObjectOfType<Player_Controller>();

        contador.text = a.coins + "/10";
    }

    // Update is called once per frame
    void Update()
    {
        contador.text = a.coins.ToString("f0") + "/10";
    }
}
