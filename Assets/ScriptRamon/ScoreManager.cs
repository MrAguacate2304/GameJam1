using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManager;
    int score = 0;
    public Text scoreText;
    private void Start()
    {
        scoreManager = this;
    }
    public void RaiseScore(int s)
    {
        score += s;
        scoreText.text = score + "";
    }
}
