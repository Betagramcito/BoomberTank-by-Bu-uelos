using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float velocidadRotacion = 90f; 
    [SerializeField] private Vector2 direccion;
    private Rigidbody2D rb2D;
    private float anguloRotacion = 0f; // Ángulo de rotación inicial (mirando al norte)

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        transform.rotation = Quaternion.Euler(0, 0, 0); // Asegura que el tanque inicie mirando al norte
    }

    private void Update()
    {
        direccion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        // Cambia el ángulo de rotación según la tecla presionada
        if (Input.GetKey(KeyCode.W))
        {
            anguloRotacion = 0f; // Norte
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anguloRotacion = -90f; // Este (rotación en sentido horario)
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anguloRotacion = -180f; // Sur
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anguloRotacion = -270f; // Oeste
        }

        // Aplica la rotación al objeto
        transform.rotation = Quaternion.Euler(0, 0, anguloRotacion);
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }
}
