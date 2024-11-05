using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Vector2 direccion;
    private Rigidbody2D rb2D;
    private float anguloRotacion = 0f;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void Update()
    {
        // Detecta solo un eje a la vez
        if (Input.GetKey(KeyCode.W))
        {
            direccion = Vector2.up;
            anguloRotacion = 0f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direccion = Vector2.right;
            anguloRotacion = -90f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direccion = Vector2.down;
            anguloRotacion = -180f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            direccion = Vector2.left;
            anguloRotacion = -270f;
        }
        else
        {
            // Si no hay teclas presionadas, no se mueve
            direccion = Vector2.zero;
        }

        // Actualiza la rotación según la dirección
        transform.rotation = Quaternion.Euler(0, 0, anguloRotacion);
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }
}
