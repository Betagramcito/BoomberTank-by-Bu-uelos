using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // M�todo que se llamar� al presionar el bot�n
    public void CambiarEscena(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
}
