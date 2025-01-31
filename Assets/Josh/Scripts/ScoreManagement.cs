using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManagement : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public Timer time;
    public Gun gun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time.isRunning)
        {
            scoreText.text = $"Score: {score}";
            gun.canShoot = true;
        }
        else
            gun.canShoot = false;
    }
}
