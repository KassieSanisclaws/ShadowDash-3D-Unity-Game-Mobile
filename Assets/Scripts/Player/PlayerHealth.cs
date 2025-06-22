using UnityEngine;
using UnityEngine.UI; // Required for UI elements like Image

public class PlayerHealth : MonoBehaviour
{
    public int health; // Player's health, can be modified in the Inspector
    public int maxHealth = 5; // Maximum health, can be modified in the Inspector
    private int currHearts; // Current health of the player

    public Image[] heartImg; // Array of hearts to represent player health visually assigned in the Inspector [5 hearts]
    public Sprite fullHeart; // Full heart sprite assigned in the Inspector
    public Sprite emptyHeart; // Empty heart sprite assigned in the Inspector


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currHearts = health = 5; // Initialize current health to the starting health
        UpdateHeartsUI(); // Update the health UI to reflect the current health
    }

    // Triggers when the player takes damage
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Boundary"))
        {
            TakeDamage(1);
        }
        else if (other.CompareTag("Obstacle"))
        {
            TakeDamage(1);
        }
    }

    // Method for TakeDamage, reduces health by the specified amount
    void TakeDamage(int damage)
    {
        currHearts -= damage; // Reduce current health by the damage amount
        currHearts = Mathf.Clamp(currHearts, 0, maxHealth); // Ensure current health does not exceed max health or go below zero
        UpdateHeartsUI(); // Update the health UI to reflect the new health

        if (currHearts <= 0) // Check if the player has no health left
        {
            GameOver(); // Call the Game Over method
        }
    }

    // Method to update the health UI based on current health
     void UpdateHeartsUI()
    {
        for (int i = 0;  i < heartImg.Length; i++)
        {
            heartImg[i].sprite = i < currHearts ? fullHeart : emptyHeart;

        }
    }

    // Method to heal the player, increases health by the specified amount
    void Heal(int healAmount)
    {
        currHearts += healAmount; // Increase current health by the heal amount
        currHearts = Mathf.Clamp(currHearts, 0, maxHealth); // Ensure current health does not exceed max health
        UpdateHeartsUI(); // Update the health UI to reflect the new health
    }

    // Game Over method Player Out of Hearts
    void GameOver()
    {
        // Load the Game Over scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GameOver);
    }

}
