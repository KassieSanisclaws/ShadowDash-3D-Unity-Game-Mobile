using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void NewGame()
    {
        // Logic to start a new game
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.Level1);
        Debug.Log("Starting a new game...");
        // You can add more functionality here, like loading a scene or initializing game state
    }

    public void LoadGame()
    {
        // Logic to load an existing game
        Debug.Log("Loading an existing game...");
        // You can add more functionality here, like loading a saved game state
    }

    public void Settings()
    {
        // Logic to open settings menu
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.Settings);
        Debug.Log("Opening settings menu...");
        // You can add more functionality here, like displaying a settings UI
    }

    public void Creadits()
    {
        // Logic to display credits
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.Credits);
        Debug.Log("Displaying credits...");
        // You can add more functionality here, like showing a credits UI
    }

}
