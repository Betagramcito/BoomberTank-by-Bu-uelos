using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStart : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().rootCount + 1);

    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
