using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ballPrefab;
    public GameObject ballTP;
    void Start()
    {
        Instantiate(ballPrefab, ballTP.transform.position, ballTP.transform.rotation);
        Instantiate(ballPrefab, ballTP.transform.position, ballTP.transform.rotation);
        Instantiate(ballPrefab, ballTP.transform.position, ballTP.transform.rotation);
        Instantiate(ballPrefab, ballTP.transform.position, ballTP.transform.rotation);
        Instantiate(ballPrefab, ballTP.transform.position, ballTP.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
