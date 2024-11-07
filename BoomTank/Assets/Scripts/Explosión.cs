using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Explosión : MonoBehaviour
{
    public float delay = 3.0f;
    public GameObject Particulas;
    public AudioClip explosionSound;
    public float explosionRadius = 5.0f;  // Radio de la explosión ajustable en 2D

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
        // Instancia las partículas de explosión y ajusta su escala para reflejar el radio
        GameObject explosion = Instantiate(Particulas, transform.position, Quaternion.identity);
        explosion.transform.localScale = Vector3.one * explosionRadius;

        // Reproduce el sonido de explosión
        audioSource.Play();

        // Configura un colisionador circular para detectar objetos afectados por la explosión en 2D
        CircleCollider2D explosionCollider = explosion.AddComponent<CircleCollider2D>();
        explosionCollider.isTrigger = true;
        explosionCollider.radius = explosionRadius;

        Destroy(gameObject, explosionSound.length);
        Destroy(explosion, 1f);
    }
}

