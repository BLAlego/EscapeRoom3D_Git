using UnityEngine;
using UnityEngine.Events;

// Implementacion B (Alexander): estado del puzzle, intentos y evento al resolver.
public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string solution = "1234";
    [SerializeField] private int maxAttempts = 3;
    [SerializeField] private UnityEvent onSolved;

    private int attempts;

    public bool IsSolved { get; private set; }

    public void TrySolve(string input)
    {
        if (IsSolved || attempts >= maxAttempts)
        {
            return;
        }

        attempts++;

        if (input == solution)
        {
            IsSolved = true;
            Debug.Log("Puzzle resuelto.");
            onSolved?.Invoke();
        }
        else
        {
            Debug.Log("Intento fallido " + attempts + "/" + maxAttempts);
        }
    }
}
