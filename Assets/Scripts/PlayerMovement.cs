using UnityEngine;

/// <summary>
/// Script que controla el movimiento del jugador
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    // Velocidad de movimiento del jugador
    public float speed;

    // Update se ejecuta una vez por frame
    private void Update()
    {
        // Comprobamos qué tecla se está pulsando para el movimiento del jugador
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed);
        }
    }
}