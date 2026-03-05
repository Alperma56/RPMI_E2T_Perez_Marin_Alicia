using UnityEngine;
using TMPro;
using UnityEditor;

/// <summary>
/// Script que gestiona los elementos de la interfaz durante el juego
/// </summary>
public class UIManager : MonoBehaviour
{
    // Referencia al componente de texto donde se muestra el contador
    public TextMeshProUGUI mergeCountText;

    // Contador interno de fusiones realizadas
    private int mergeCount = 0;

    /// <summary>
    /// Método público que incrementa el contador de fusiones y actualiza el texto
    /// </summary>
    private void Update()
    {
        mergeCountText.text = mergeCount.ToString();
    }
    public void AddMerge()
    {
        mergeCountText.text = "Merges: " + mergeCount;
        mergeCount++;
    }
}