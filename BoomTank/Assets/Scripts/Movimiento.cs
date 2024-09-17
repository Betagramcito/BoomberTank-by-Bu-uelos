using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float velocidadRotacion = 90f; 
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
        direccion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        if (Input.GetKey(KeyCode.W))
        {
            anguloRotacion = 0f; 
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anguloRotacion = -90f; 
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anguloRotacion = -180f; 
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anguloRotacion = -270f; 
        }

        transform.rotation = Quaternion.Euler(0, 0, anguloRotacion);
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }
}
