using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2 : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 movimiento = Vector2.zero;

        if (Input.GetKey(KeyCode.I)) 
        {
            movimiento.y = 1;
        }
        else if (Input.GetKey(KeyCode.K)) 
        {
            movimiento.y = -1;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            movimiento.x = 1;
        }
        else if (Input.GetKey(KeyCode.J)) 
        {
            movimiento.x = -1;
        }

        if (movimiento.y > 0) 
        {
            transform.rotation = Quaternion.Euler(0, 0, 0); 
        }
        else if (movimiento.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180); 
        }
        else if (movimiento.x > 0) 
        {
            transform.rotation = Quaternion.Euler(0, 0, -90); 
        }
        else if (movimiento.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90); 
        }

        movimiento = movimiento.normalized * velocidad * Time.deltaTime;

        transform.Translate(movimiento, Space.World);
    }
}