using UnityEngine;

/// <summary>
/// Script que gestiona la fusión (merge) de los objetos
/// </summary>
public class MergeController : MonoBehaviour
{
    // Nivel de merge de este objeto (1, 2, 3 o 4)
    public int mergeLevel = 1;

    // Prefab del objeto del siguiente nivel que se creará al fusionarse (si es el nivel máximo, se deja vacío)
    public GameObject nextLevelPrefab;

    // Variable para evitar que un mismo objeto se fusione dos veces
    private bool hasMerged = false;

    // Se ejecuta cuando este objeto colisiona con otro
    private void OnCollisionEnter(Collision collision)
    {
        // Si ya se ha fusionado, no se hace nada
        if (!hasMerged)
        {

            // Comprobamos que el otro objeto es un objeto mergeable
            if (collision.gameObject.CompareTag("Mergeable"))
            {
                print("choque");
                // Obtenemos el componente MergeController del otro objeto
                MergeController otherMerge = collision.gameObject.GetComponent<MergeController>();

                // Comprobamos que el otro objeto es del mismo nivel
                if (otherMerge.mergeLevel == mergeLevel)
                {
                    // Comprobamos que el otro objeto no se ha fusionado ya
                    if (!otherMerge.hasMerged)
                    {
                        // Marcamos ambos objetos como fusionados
                        hasMerged = true;
                        otherMerge.hasMerged = true;

                        // Si hay un prefab de siguiente nivel, lo instanciamos en la posición de este objeto
                        if (nextLevelPrefab != null)
                        {
                            Instantiate(nextLevelPrefab, Vector3.zero, Quaternion.identity);
                        }

                        // Destruimos ambos objetos originales
                        Destroy(otherMerge.gameObject);
                        Destroy(gameObject);
                    }
                }
            }
        }
    }
}