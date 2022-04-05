using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gate_Controller : MonoBehaviour
{
    private SpriteRenderer sprite;

    public Player_Controller a;
    public int numScene;

   
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
                SceneManager.LoadScene(numScene);
                a.coins = 0;
            }
        }
    }
}





