using UnityEngine;

// Version antigua de la puerta (antes de DoorController).
public class OldDoorController : MonoBehaviour
{
    [SerializeField] private bool isOpen;

    public void Open()
    {
        isOpen = true;
        Debug.Log("Puerta antigua abierta.");
    }
}
