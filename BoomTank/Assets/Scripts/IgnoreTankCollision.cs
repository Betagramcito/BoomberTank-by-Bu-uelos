using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreTankCollision : MonoBehaviour
{
    public GameObject tanque1;
    public GameObject tanque2;

    void Start()
    {
        // Asigna la capa directamente si no lo has hecho en el editor
        tanque1.layer = LayerMask.NameToLayer("Tanque1");
        tanque2.layer = LayerMask.NameToLayer("Tanque2");

        // Asegúrate de que estas capas no colisionen en la física del motor
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Tanque1"), LayerMask.NameToLayer("Tanque2"));
    }
}
