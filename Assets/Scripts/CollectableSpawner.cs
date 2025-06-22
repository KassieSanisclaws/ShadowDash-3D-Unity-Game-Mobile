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

            if (chance < 0.4f)
            {
                Instantiate(RandomCommonCollectible(), point.position, Quaternion.identity);
            }
            else if (chance < 0.7f)
            {
                Instantiate(RandomMediumCollectible(), point.position, Quaternion.identity);
            }
            else if (chance < 0.9f)
            {
                Instantiate(shurikenPrefab, point.position, Quaternion.identity);
            }
            else
            {
                Instantiate(dragonBallPrefab, point.position, Quaternion.identity);
            }
        }
    }

        GameObject RandomCommonCollectible()
    {
        return Random.value < 0.5f ? coinPrefab : durianFruitPrefab;
    }

    GameObject RandomMediumCollectible()
    {
        return dragonFruitPrefab;
    }
}
