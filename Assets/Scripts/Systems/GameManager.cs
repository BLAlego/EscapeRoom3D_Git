using UnityEngine;

// Controla el estado general de la partida. Initialize() debe ejecutarse UNA sola vez.
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public bool HasKey { get; private set; }

    private int initializeCount;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        Debug.Log("Cargando partida..."); // B (Adrian)
        Initialize(); // A (Rafaela) + B: una sola llamada, Initialize() no puede repetirse
    }

    public void Initialize()
    {
        initializeCount++;

        if (initializeCount > 1)
        {
            Debug.LogError("GameManager.Initialize() se ejecuto " + initializeCount + " veces: la partida se reinicio dos veces.");
            return;
        }

        HasKey = false;
        Debug.Log("GameManager inicializado (una vez).");
    }

    public void ObtainKey()
    {
        HasKey = true;
    }
}
