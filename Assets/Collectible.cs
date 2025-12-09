using UnityEngine;






public class Collectible : MonoBehaviour
{

    // Triggered when something enters the collectible's trigger collider
    private void OnTriggerEnter(Collider other)
    {

        // Only react if the object touching is tagged "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("COLLECTIBLE PICKED UP!");

            // Add score
            ScoreSystem.instance.AddScore(1);

            // Destroy collectible
            Destroy(gameObject);
        }
    }
}




