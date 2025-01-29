using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody rb;
    public float duration;
    public float force;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * force, ForceMode.Impulse);
        Destroy(gameObject, duration);
    }
    private void Update()
    {
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Target"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Instantiate(collision.gameObject, SpawnPos(), collision.transform.rotation);
        }
    }
    public Vector3 SpawnPos()
    {
        float xRange = Random.Range(-3, 3.6f);
        float yRange = Random.Range(1, 3);
        Vector3 randomPos = new Vector3(xRange, yRange, 8);
        return randomPos;
    }
}
