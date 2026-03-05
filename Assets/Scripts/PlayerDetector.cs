using UnityEngine;

/// <summary>
/// Script que detecta objetos mergeables delante del jugador usando un Raycast
/// </summary>
public class PlayerDetector : MonoBehaviour
{
    // Distancia máxima de detección del Raycast
    public float detectionRange;

    // Referencia al material del jugador
    public Material playerMaterial;

    // Color en el que se resaltará el jugador
    public Color highlightColor;

    // Color original del jugador
    private Color originalColor;

    // Registra si ya está resaltado
    private bool isHighlighted;

    // Update se ejecuta una vez por frame
    private void Update()
    {
        // Lanzamos un Raycast para detectar objetos mergeables
        if (Physics.Raycast(transform.position, Vector3.up, detectionRange, LayerMask.GetMask("Mergeable")))
        {
            if (!isHighlighted)
            {
                // Resalta al jugador cambiando su color
                originalColor = playerMaterial.color;
                playerMaterial.color = highlightColor;
                isHighlighted = true;
            }
        }
        else
        {
            if (isHighlighted)
            {
                // Restaura el color original
                playerMaterial.color = originalColor;
                isHighlighted = false;
            }
        }
    }
}