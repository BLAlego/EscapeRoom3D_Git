using UnityEngine;

// Version antigua de la puerta (antes de DoorController).
public class OldDoorController : MonoBehaviour
{
    [SerializeField] private bool isOpen;
    [SerializeField] private bool isLocked = true;

    public void Open()
    {
        if (isLocked)
        {
            Debug.Log("La puerta antigua esta cerrada con llave.");
            return;
        }

        isOpen = true;
        Debug.Log("Puerta antigua abierta.");
    }
}
