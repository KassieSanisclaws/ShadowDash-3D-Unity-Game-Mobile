using UnityEngine;
using System.Collections; // Required for IEnumerator and Coroutine functionality
using System.Collections.Generic; // Required for List functionality    

public class ObstacleSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    [Header("Obstacles")]
    public GameObject cratePrefab;
    public GameObject firePrefab;
    public GameObject arrowPrefab;
    public GameObject boulderPrefab;

    public float spawnInterval = 3f; // time between spawn waves

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnObstacleWaves());
    }

    IEnumerator SpawnObstacleWaves()
    {
        while (true)
        {
            SpawnObstacleWave();
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    void SpawnObstacleWave()
    {
        // Decide how many obstacles to spawn: 2 or 3
        int numToSpawn = Random.Range(2, 4); // 2 or 3

        // Create a list of available spawn points
        List<Transform> availablePoints = new List<Transform>(spawnPoints);

        for (int i = 0; i < numToSpawn && availablePoints.Count > 0; i++)
        {
            int pointIndex = Random.Range(0, availablePoints.Count);
            Transform spawnPoint = availablePoints[pointIndex];

            Instantiate(GetRandomObstacle(), spawnPoint.position, Quaternion.identity);
            availablePoints.RemoveAt(pointIndex); // prevent duplicates
        }
    }

    GameObject GetRandomObstacle()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0: return cratePrefab;
            case 1: return firePrefab;
            case 2: return arrowPrefab;
            case 3: return boulderPrefab;
            default: return cratePrefab;
        }
    }
}
