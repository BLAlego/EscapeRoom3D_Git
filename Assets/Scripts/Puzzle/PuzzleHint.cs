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
}
