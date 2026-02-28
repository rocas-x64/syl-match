using UnityEngine;

public class collision : MonoBehaviour
{
private bool playerInside = false;
private bool player2Inside = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            playerInside = true;
            Debug.Log("Player 1 is inside\n");
        }
        else if (other.CompareTag("Player2")){
            player2Inside = true;
            Debug.Log("Player 2 is inside\n");
            }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            playerInside = false;
            Debug.Log("Player 1 is outside\n");
        }
        else if (other.CompareTag("Player2"))
        {
            player2Inside = false;
            Debug.Log("Player 2 is outside\n");
        }
    }

    void Update()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.LeftShift))
        {
            TriggerInteraction();
        }

        if (player2Inside && Input.GetKeyDown(KeyCode.RightShift))
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