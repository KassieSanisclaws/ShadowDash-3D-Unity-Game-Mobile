using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void OnNewGameButton()
    {
        SceneManager.LoadScene("Level1"); // Replace with your actual game scene name
    }

    public void OnLoadGameButton()
    {
        // Add your load logic here, for now just load the Game scene
        SceneManager.LoadScene("Game");
    }

    public void OnSettingsButton()
    {
        SceneManager.LoadScene("Settings");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
