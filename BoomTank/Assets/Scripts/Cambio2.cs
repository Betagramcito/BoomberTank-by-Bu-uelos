using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambio2 : MonoBehaviour
{
    public string menuSceneName = "Menu"; // Cambia esto por el nombre exacto de tu escena de men�

    private void OnDestroy()
    {
        SceneManager.LoadScene(menuSceneName);
    }
}
