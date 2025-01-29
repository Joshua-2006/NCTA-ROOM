using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public int ballsLeft = 5;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI ballDisplay;
    public GameObject door;
    public bool hasStarted;
    public BallStart bs;
    public HitEnter he1;
    public HitEnter he2;
    public HitEnter he3;
    public HitEnter he4;
    public HitEnter he5;
    public HitEnter he6;
    public HitEnter he7;
    public HitEnter he8;
    public HitEnter he9;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = $"Score: {score}";
        ballDisplay.text = $"Balls: {ballsLeft}";
    }

    public void startGame()
    {
        if (!hasStarted)
        {
            //door.SetActive(false);
        bs.startSpawn();
        ballsLeft = 5;
        score = 0;
        hasStarted = true;
        }
    }

    public void resetGame()
    {
        hasStarted = false;
        ballsLeft = 0;
        score = 0;
        he1.isHit = false;
        he2.isHit = false;
        he3.isHit = false;
        he4.isHit = false;
        he5.isHit = false;
        he6.isHit = false;
        he7.isHit = false;
        he8.isHit = false;
        he9.isHit = false;
        bs.restartGame();
    }
}
