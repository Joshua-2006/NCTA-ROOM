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
        door.SetActive(false);
        ballsLeft = 5;
        hasStarted = true;
        }
    }
}
