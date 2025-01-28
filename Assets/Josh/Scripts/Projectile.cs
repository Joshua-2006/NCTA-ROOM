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
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
