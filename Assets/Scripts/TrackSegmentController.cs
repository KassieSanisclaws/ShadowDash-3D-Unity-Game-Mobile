using UnityEngine;

public class TrackSegmentController : MonoBehaviour
{
    public Transform endPoint; // drag EndPoint object in inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TrackManager.Instance.SpawnNextSegment(endPoint.position);
            Destroy(gameObject, 10f); // optional cleanup after delay
        }
    }
}
