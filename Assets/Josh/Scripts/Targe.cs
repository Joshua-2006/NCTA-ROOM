using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Targe : MonoBehaviour
{
    public ScoreManagement sm;
    private void Update()
    {
        sm = FindAnyObjectByType<ScoreManagement>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            sm.score += 50;
            sm.scoreText.text = $"Score: {sm.score}";
        }
    }
}
