using UnityEngine;

// Pista del puzzle (Adrian, Feature_Puzzle): muestra una ayuda en la Console.
public class PuzzleHint : MonoBehaviour
{
    [SerializeField] private string hint = "Busca los numeros escondidos en la habitacion.";

    [ContextMenu("Mostrar pista")]
    public void ShowHint()
    {
        Debug.Log("Pista: " + hint);
    }

    // WIP: pista extra al fallar varias veces (experimental, no integrar todavia).
    public string GetExtraHint(int failedAttempts)
    {
        return failedAttempts >= 2 ? "Pista extra: el codigo tiene 4 digitos." : string.Empty;
    }
}
