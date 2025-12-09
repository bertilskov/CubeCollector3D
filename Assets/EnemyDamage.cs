using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamage : MonoBehaviour
{
    // Called when the enemy collides with another collider
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object hit is the player
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("PLAYER HIT! Restarting...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // Called when entering a trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the trigger hit belongs to the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER HIT! Restarting...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}


