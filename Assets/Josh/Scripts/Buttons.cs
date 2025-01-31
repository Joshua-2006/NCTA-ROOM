using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Timer time;
    public List<GameObject> Targes;
    public GameObject targe;
    public int numberOfTargeToSpawn;
    public ScoreManagement sm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FindObjectsOfType<Targe>();
        
        if(time.time == 0)
        {
            Destroy(targe);
            foreach (GameObject target in Targes)
                {
                    Destroy(target);
                }
            Targes.Clear();
        }
    }
    public void Button()
    {
        time.isRunning = true;
        for (int i = 0; i < numberOfTargeToSpawn; i++)
        {
            Targes.Add(Instantiate(targe, SpawnPos(), targe.transform.rotation));
        }
    }
    public void Reset()
    {
        foreach(GameObject target in Targes)
        {
            Destroy(target);
        }
        Targes.Clear();
        time.isRunning = false;
        time.time = 60;
        time.startTime = 60;
        sm.score = 0;
        sm.scoreText.text = $"Score: {sm.score}";
    }
    public Vector3 SpawnPos()
    {
        float xRange = Random.Range(-2, 1);
        float yRange = Random.Range(1, 2);
        float zRange = Random.Range(8, 12);
        Vector3 randomPos = new Vector3(xRange, yRange, zRange);
        return randomPos;
    }
}
