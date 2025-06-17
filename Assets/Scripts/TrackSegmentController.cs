using UnityEngine;

public class TrackSegmentController : MonoBehaviour
{
    public GameObject[] obstaclePrefabs; // Drag multiple obstacles if desired
    public int maxObstaclesPerSegment = 2;

    void Start()
    {
        Transform spawnPointsParent = transform.Find("ObstacleSpawnPoints");
        if (spawnPointsParent == null) return;

        Transform[] spawnPoints = new Transform[spawnPointsParent.childCount];
        for (int i = 0; i < spawnPoints.Length; i++)
            spawnPoints[i] = spawnPointsParent.GetChild(i);

        int obstaclesToSpawn = Random.Range(1, maxObstaclesPerSegment + 1);
        for (int i = 0; i < obstaclesToSpawn; i++)
        {
            Transform point = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject prefab = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];
            Instantiate(prefab, point.position, Quaternion.identity, this.transform);
        }
    }
}
