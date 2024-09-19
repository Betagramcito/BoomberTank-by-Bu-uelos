using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosión : MonoBehaviour
{
    public float explosionRadius = 5.0f;
    public float explosionForce = 10.0f;
    public float damage = 50.0f;
    public float delay = 3.0f;
    //public GameObject explosionEffect;
    void Start()
    {
        Invoke("Explode", delay);
    }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider hit in colliders)
        {
            Salud health = hit.GetComponent<Salud>();
            if (health != null)
            {
                health.TakeDamage(damage);
            }
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }
        }
        Destroy(gameObject); 

    }
    void Update()
    {
        
    }
}
