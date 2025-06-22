using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int coinCount = 0;
    public Text coinText;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void AddCoin()
    {
        coinCount++;
        if (coinText != null)
            coinText.text = "Coins: " + coinCount;
    }

    public void GameOver()
    {
        // Show Game Over screen
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
