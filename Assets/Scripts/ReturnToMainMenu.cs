using UnityEngine;

public class ReturnToMainMenu : MonoBehaviour
{
    public void LoadLevelTwo()
    {
       // Assuming you have a scene named "MainMenu" in your build settings
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.Level2);
    }    
}
