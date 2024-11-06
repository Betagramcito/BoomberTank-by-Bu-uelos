
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour
{
    
    public void CambioAEscena()
    {
        SceneManager.LoadScene("Menu");
    }
}
