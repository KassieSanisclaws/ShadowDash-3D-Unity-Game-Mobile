using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsUI : MonoBehaviour
{
    public void OnBackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
