using UnityEngine;
using UnityEngine.UI;
using TMPro; // Ensure you have TextMeshPro package installed
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public TMP_Text finalScoreText;

    void Start()
    {
        if (GameManager.instance != null)
        {
            finalScoreText.text = "Score: " + GameManager.instance.coinCount;
        }
    }

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.ManiMenu);
    }
}
