using UnityEngine;

public class TrackSegmentController : MonoBehaviour
{
    public GameObject[] trackSegmentPrefabs; // All possible segments
    public float zOffset = 30f; // Distance ahead to spawn the new segment

    private bool hasSpawned = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasSpawned && other.CompareTag("Player"))
        {
            hasSpawned = true;

            SpawnNextSegment();
        }
    }

    void SpawnNextSegment()
    {
        int index = Random.Range(0, trackSegmentPrefabs.Length);
        GameObject nextSegment = Instantiate(trackSegmentPrefabs[index]);

        Transform attachPoint = nextSegment.transform.Find("AttachPoint");

        if (attachPoint != null)
        {
            Vector3 offset = attachPoint.position - nextSegment.transform.position;
            nextSegment.transform.position = transform.position - offset;
        }
        else
        {
            Debug.LogWarning("AttachPoint not found on prefab!");
        }
    }
}
