using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Explosión : MonoBehaviour
{
    public float explosionRadius = 5.0f;
    public float explosionForce = 10.0f;
    public float damage = 25.0f;
    public float delay = 3.0f;
    public GameObject Particulas;
    //public GameObject explosionEffect;
    void Start()
    {
        Invoke("Explode", delay);
    }

    void Explode()
    {
        GameObject explosion = Instantiate(Particulas,transform.position,Quaternion.identity);
        Destroy(gameObject); 
        Destroy(explosion, 1f);

    }
    void Update()
    {
        
    }
}
