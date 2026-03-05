using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Script que controla el menú principal del juego
/// ESTE SCRIPT NO SE PUEDE MODIFICAR
/// </summary>
public class MenuController : MonoBehaviour
{
    /// <summary>
    /// Función para cargar la escena principal del juego
    /// </summary>
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    /// <summary>
    /// Función para salir del juego
    /// </summary>
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}