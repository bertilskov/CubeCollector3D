using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreSystem : MonoBehaviour
{
    // A static reference so other scripts can access ScoreSystem easily
    public static ScoreSystem instance;


    // UI text that displays the score
    public TMP_Text scoreText;

    // Current score value
    private int score = 0;

    // Score needed to win the game
    public int targetScore = 20;

    private void Awake()
    {
        // Set the instance so it can be accessed globally
        instance = this;
    }

    // Call this function whenever the player collects a collectible
    public void AddScore(int amount)
    {
        // Increase score
        score += amount;

        // Update the score text on the UI
        scoreText.text = "Score: " + score;

        // Check if player reached the target score
        if (score >= targetScore)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        // Log for debugging
        Debug.Log("YOU WIN!");

        // Restart the scene (simple win behavior)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}



