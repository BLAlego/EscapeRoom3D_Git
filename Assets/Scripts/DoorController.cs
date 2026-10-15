using UnityEngine;

// Controlador nuevo de la puerta: reemplaza a OldDoorController.
public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private bool isOpen;

    public void Open()
    {
        if (!isOpen)
        {
            return;
        }

        isOpen = true;

        if (animator != null)
        {
            animator.SetTrigger("Open");
        }

        Debug.Log("Puerta abierta.");
    }

    [ContextMenu("Probar puerta")]
    private void TestOpen()
    {
        Open();
    }
}
