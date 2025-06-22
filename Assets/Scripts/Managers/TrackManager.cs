using System.Collections.Generic;
using UnityEngine;

public class TrackManager : MonoBehaviour
{
    public static TrackManager Instance;

    public GameObject trackSegmentPrefab;
    private Vector3 nextSpawnPosition;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    void Start()
    {
        // Start with first track segment
        SpawnNextSegment(Vector3.zero);
    }

    public void SpawnNextSegment(Vector3 spawnPos)
    {
        GameObject newSegment = Instantiate(trackSegmentPrefab, spawnPos, Quaternion.identity);
        nextSpawnPosition = newSegment.GetComponent<TrackSegmentController>().endPoint.position;
    }
}
