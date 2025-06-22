using UnityEngine;
using TMPro; // Required for TextMeshPro UI elements

public class LevelOneGameManager : MonoBehaviour
{
    public static LevelOneGameManager instance;

    public int scoreCount = 0;
    public  TMP_Text scoreText;

    public int winScore = 13000; // Score needed to win the game
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    public void AddScore(int amount)
    {
        scoreCount += amount;

        if (scoreText != null)
            scoreText.text = "Score: " + scoreCount;

        if(scoreCount >= winScore)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.LevelCleared); // Load the next level
        Debug.Log("You win! Final Score: " + scoreCount);
        // Here you can add logic to transition to the next level or show a win screen
        // For example, you could load a new scene or display a UI panel
    }
}
