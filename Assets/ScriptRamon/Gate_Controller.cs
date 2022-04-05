using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gate_Controller : MonoBehaviour
{

    public Player_Controller a;

    void Start()
    {
        a = FindObjectOfType<Player_Controller>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            if (a.coins >= 10)
            {
                SceneManager.LoadScene("Nivel 1");
                a.coins = 0;
            }
        }
    }
}
