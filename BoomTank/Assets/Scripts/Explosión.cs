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
    public AudioClip explosionSound; 
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); 
        audioSource.clip = explosionSound;
        audioSource.playOnAwake = false; 
        Invoke("Explode", delay);
    }

    void Explode()
    {
        GameObject explosion = Instantiate(Particulas, transform.position, Quaternion.identity);


        audioSource.Play();

        Destroy(gameObject, explosionSound.length);
        Destroy(explosion, 1f);
    }

    void Update()
    {

    }
}
