using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Salud : MonoBehaviour
{
    public float saludMaxima = 100f;
    public float saludActual;
    public float damage = 25f;

    public List<Image> corazones; // Arrastra aquí las imágenes de corazón desde el Inspector

    private void Start()
    {
        saludActual = saludMaxima;
        ActualizarCorazonesUI();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Explosion"))
        {
            TakeDamage(damage);
        }
    }

    public void TakeDamage(float damage)
    {
        saludActual -= damage;
        saludActual = Mathf.Max(saludActual, 0); // Asegura que no baje de 0

        // Actualizar la UI de corazones
        ActualizarCorazonesUI();

        if (saludActual <= 0)
        {
            Destroy(gameObject);
        }
    }

    void ActualizarCorazonesUI()
    {
        int corazonesActivos = Mathf.CeilToInt(saludActual / 25f);

        // Recorre la lista de corazones y activa/desactiva según la salud
        for (int i = 0; i < corazones.Count; i++)
        {
            corazones[i].enabled = i < corazonesActivos;
        }
    }
}