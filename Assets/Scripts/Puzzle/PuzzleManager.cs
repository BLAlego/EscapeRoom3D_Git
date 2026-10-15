using UnityEngine;

// Implementacion A (Adrian): valida el codigo del puzzle.
public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string correctCode = "1234";

    public bool ValidateCode(string code)
    {
        bool valid = code == correctCode;

        if (valid)
        {
            Debug.Log("Codigo correcto.");
        }
        else
        {
            Debug.Log("Codigo incorrecto.");
        }

        return valid;
    }
}
