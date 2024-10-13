using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour
{
    public float saludMaxima = 100f;
   public float saludActual;
    public float damage = 25f;

    private void Start()
    {
        saludActual = saludMaxima;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Explosion"))
        {
            TakeDamage(damage); // Ajusta el valor de damage según sea necesario
        }
    }

    public void TakeDamage(float damage)
    {
        saludActual -= damage;

        if (saludActual <= 0)
        {
            Destroy(gameObject);
        }
    }
}