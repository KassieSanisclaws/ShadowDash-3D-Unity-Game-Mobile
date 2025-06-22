using UnityEngine;

public class StartGameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
        Debug.Log("StartGameManager initialized.");
    }

    // Method to start the game
    public void StartGame()
    {
        // Logic to start the game goes here
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.Level1); 
        Debug.Log("Game Started!");
    }
}
