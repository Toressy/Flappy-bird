using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementScript : MonoBehaviour
{
    //create an array
    [SerializeField] private GameObject[] waypoint;
    private float speedPlatform = 2;
    private int index = 0;


    // Update is called once per frame
    void Update()
    {
        // Check if the distance between the current waypoint and the platform is less than 0.1f
        if (Vector2.Distance(waypoint[index].transform.position, transform.position) < 0.1f)
        {
            // Move to the next waypoint
            index += 1;
            // If reached the end of the array, wrap around to the first waypoint
            if (index >= waypoint.Length)
            {
                index = 0;
            }
        }
        // Move the platform towards the current waypoint at a certain speed
        transform.position = Vector2.MoveTowards(transform.position, waypoint[index].transform.position, Time.deltaTime * speedPlatform);
    }
}
