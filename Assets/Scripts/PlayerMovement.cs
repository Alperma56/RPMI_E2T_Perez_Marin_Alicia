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
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed*Time.deltaTime, Space.World);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed*Time.deltaTime, Space.World);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        }
    }
}