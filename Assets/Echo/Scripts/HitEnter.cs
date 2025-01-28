using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnter : MonoBehaviour
{
    public int scoreAdd;
    public bool isHit;
    public MeshRenderer mr;
    public Material red;
    public GameObject ballTP;
    public ScoreManager sm;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit)
        {
            mr.material = red;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("TossBall"))
        {
            isHit = true;
            collision.transform.position = ballTP.transform.position;
            sm.score = sm.score + scoreAdd;
            //collision.gameObject.SetActive(false);
        }
    }
}
