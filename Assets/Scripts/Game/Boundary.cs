using UnityEngine;

public class Boundary : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the boundary is a player
        if (other.CompareTag("Player"))
        {
            // If it is, destroy the player object
            Destroy(other.gameObject);
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GameOver);
        }
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
