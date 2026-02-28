using UnityEngine;

public class collisionjauge : MonoBehaviour
{
    private bool playerInside = false;

    void Update() {

    }
    

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("barreRouge"))
        {
            playerInside = false;
            Debug.Log("barre is not\n");
        }
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("barreRouge"))
        {
            playerInside = true;
            Debug.Log("barre is touching\n");
        }

    }
}
