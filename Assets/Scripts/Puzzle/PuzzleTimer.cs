using UnityEngine;

// WIP: temporizador del puzzle. Todavia no se integra a Dev.
public class PuzzleTimer : MonoBehaviour
{
    [SerializeField] private float timeLimit = 60f;

    private float elapsed;

    private void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= timeLimit)
        {
            Debug.Log("Tiempo del puzzle agotado (WIP).");
            enabled = false;
        }
    }
}
