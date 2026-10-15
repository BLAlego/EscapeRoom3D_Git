using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float sprintMultiplier = 1.5f; // Velocidad extra al correr (Caso 12)

      private void Update()
    {
        Move();
        Debug.Log("Movement system active");
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Interaction key pressed");
        }
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0f, v);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
