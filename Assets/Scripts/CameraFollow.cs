using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target to follow
    public Vector3 offSet = new Vector3(0f, 5f, -10f); // Offset from the target
    public float followSpeed = 3f; // Speed of following the target 

    private void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position based on the target's position and the offset
            Vector3 desiredPosition = target.position + offSet;

            // Smoothly interpolate to the desired position
            transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

            // Optionally, make the camera look at the target
            transform.LookAt(target);
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
