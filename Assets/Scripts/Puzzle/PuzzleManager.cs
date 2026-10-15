using UnityEngine;
using UnityEngine.Events;

// Version integrada (A + B): una sola clase PuzzleManager.
// - De A (Adrian): ValidateCode(string), la API que usara el resto del juego.
// - De B (Alexander): intentos, estado IsSolved y evento onSolved.
public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string correctCode = "1234";
    [SerializeField] private int maxAttempts = 3;
    [SerializeField] private UnityEvent onSolved;

    [Header("Prueba desde el Inspector")]
    [SerializeField] private string testCode = "1234";

    private int attempts;

    public bool IsSolved { get; private set; }

    public bool ValidateCode(string code)
    {
        // fix: normaliza el codigo (quita espacios) y no gasta intentos con entradas vacias.
        code = code == null ? string.Empty : code.Trim();
        if (code.Length == 0)
        {
            Debug.Log("Ingresa un codigo.");
            return false;
        }

        if (IsSolved)
        {
            return true;
        }

        if (attempts >= maxAttempts)
        {
            Debug.Log("Sin intentos disponibles.");
            return false;
        }

        attempts++;

        if (code == correctCode)
        {
            IsSolved = true;
            Debug.Log("Codigo correcto. Puzzle resuelto.");
            onSolved?.Invoke();
            return true;
        }

        Debug.Log("Codigo incorrecto. Intento " + attempts + "/" + maxAttempts);
        return false;
    }

    [ContextMenu("Probar codigo")]
    private void TestCode()
    {
        ValidateCode(testCode);
    }
}
