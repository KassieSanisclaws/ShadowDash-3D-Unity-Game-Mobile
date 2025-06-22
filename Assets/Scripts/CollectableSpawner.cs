using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    [Header("Collectibles")]
    public GameObject coinPrefab;
    public GameObject durianFruitPrefab;
    public GameObject dragonFruitPrefab;
    public GameObject dragonBallPrefab;
    public GameObject shurikenPrefab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnObjects(); // Call the method to spawn objects at the start
    }

    void SpawnObjects()
    {
        foreach (Transform point in spawnPoints)
        {
            float chance = Random.value;

            if (chance < 0.1f)
            {
                // 50% chance to spawn a basic collectible
                Instantiate(RandomCommonCollectible(), point.position, Quaternion.identity);
            }
            else if (chance < 0.3f)
            {
                // 20% chance to spawn an obstacle
                Instantiate(durianFruitPrefab, point.position, Quaternion.identity);
            }
            else if (chance < 0.55f)
            {
                // 5% chance to spawn a rare item
                Instantiate(dragonBallPrefab, point.position, Quaternion.identity);
            }
            else if (chance < 0.85f)
            {
                Instantiate(dragonFruitPrefab, point.position, Quaternion.identity);
            }
            else if (chance < 0.95f)
            {
                Instantiate(shurikenPrefab, point.position, Quaternion.identity);
            }
            // else: leave empty
        }
    }

    GameObject RandomCommonCollectible()
    {
        // Add more weighting logic here if needed
        int choice = Random.Range(0, 2); // 0 or 1
        return (choice == 0) ? coinPrefab : durianFruitPrefab;
    }
}
