using UnityEngine;

public class CreditsGameManager : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
        // Load the main menu scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.ManiMenu);
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
