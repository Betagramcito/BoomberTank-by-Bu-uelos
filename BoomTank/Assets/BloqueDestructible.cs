using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueDestructible : MonoBehaviour
{
    // Método para manejar colisiones
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica si el objeto que colisiona es un proyectil o el tanque
        if (collision.gameObject.CompareTag("Projectile") || collision.gameObject.CompareTag("Tank"))
        {
            Destroy(gameObject); // Destruye el bloque inmediatamente
        }
    }

}
