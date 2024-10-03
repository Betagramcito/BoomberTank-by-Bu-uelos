using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBombPlacement : MonoBehaviour
{
   public GameObject bombaPrefab; // Prefab de la bomba
    public float tiempoIgnorarColision = 0.5f; // Tiempo durante el cual se ignorará la colisión

    void ColocarBomba()
    {
        // Crear la bomba en la posición del tanque
        GameObject bomba = Instantiate(bombaPrefab, transform.position, Quaternion.identity);

        // Ignorar colisiones temporalmente entre el tanque que coloca la bomba y la bomba
        Collider tanqueCollider = GetComponent<Collider>();
        Collider bombaCollider = bomba.GetComponent<Collider>();

        // Ignorar colisión entre el tanque y la bomba
        Physics.IgnoreCollision(tanqueCollider, bombaCollider, true);

        // Volver a activar la colisión después de un corto periodo de tiempo
        StartCoroutine(HabilitarColisionDespues(tanqueCollider, bombaCollider, tiempoIgnorarColision));
    }

    IEnumerator HabilitarColisionDespues(Collider tanqueCollider, Collider bombaCollider, float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        Physics.IgnoreCollision(tanqueCollider, bombaCollider, false); // Reactivar colisiones
    }
}
