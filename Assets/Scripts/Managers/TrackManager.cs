using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackManager : MonoBehaviour
{
    public GameObject[] trackSegment;
    [SerializeField] int zPos=137; // Default z position for the track segment2
    [SerializeField] bool createTrackSegment = false; // Flag to control the creation of track segment 2
    [SerializeField] int trackSegmentPosition; // Position of the track segment in the scene
    void Update()
    {
        if(createTrackSegment == false)
        {
           createTrackSegment = true; // Set the flag to true to start creating track segments
           // Start the coroutine to generate track segments
           StartCoroutine(SegmentGenerator());
        }
        
    }

    IEnumerator SegmentGenerator()
    {
        trackSegmentPosition = Random.Range(0, trackSegment.Length); // Randomly select a track segment prefab
        Instantiate(trackSegment[trackSegmentPosition], new Vector3(0,0, zPos), Quaternion.identity); // Instantiate the selected track segment prefab at the start position
        zPos += 137; // Increment the z position for the next segment
        yield return new WaitForSeconds(10); // Placeholder for actual segment generation logic   
        createTrackSegment = false; // Reset the flag to false after generating the segment
    }
}
