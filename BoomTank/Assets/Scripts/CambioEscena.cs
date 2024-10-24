using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // Método que se llamará al presionar el botón
    public void CambiarEscena(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
}
