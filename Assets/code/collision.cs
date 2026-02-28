using UnityEngine;

public class collision : MonoBehaviour
{
private bool playerInside = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            playerInside = true;
            Debug.Log("player is inside\n");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            playerInside = false;
            Debug.Log("player is outside\n");
    }

    void Update()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.E))
        {
            TriggerInteraction();
        }
    }

    void TriggerInteraction()
    {
        Debug.Log("Interaction triggered!");
        // Call your function here
    }
}