using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaController : MonoBehaviour
{
    private SoundManager soundManager;
    private void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        soundManager.SeleccionAudio(0, 0.5f);
        ScoreManager.scoreManager.RaiseScore(1);
        Destroy(gameObject);

    }
}
