using UnityEngine;
using UnityEngine.SceneManagement; // Import for scene management

public class WinTrigger : MonoBehaviour
{
    // This will handle when the player touches the object
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player is the one colliding with the object
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}



