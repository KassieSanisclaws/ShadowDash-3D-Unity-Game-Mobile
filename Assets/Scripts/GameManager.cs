using UnityEngine;

public class GameManager : MonoBehaviour
{
   // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public static GameManager instance;
    public int coinCount = 0;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void AddCoin()
    {
        coinCount++;
        // Update UI, play sound etc.
    }

    public void GameOver()
    {
        // Show Game Over screen
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
