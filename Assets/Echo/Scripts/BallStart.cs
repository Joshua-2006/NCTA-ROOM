using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ballPrefab;
    public GameObject ballTP;
    public int numberOfBallsToSpawn;

    public List<GameObject> currentBalls;
    void Start()
    {
        //startSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startSpawn()
    {

        for (int i = 0; i < numberOfBallsToSpawn; i++)
        {
            currentBalls.Add(Instantiate(ballPrefab, ballTP.transform.position, ballTP.transform.rotation));
        }
    }

    public void restartGame()
    {
        
        foreach(GameObject ball in currentBalls)
        {
            Destroy(ball);
        }
        currentBalls.Clear();
        //Destroy(FindObjectOfType<BallPrefab>())
    }
}
