using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Reference to the SmileScript component attached to the "smile" game object
    [SerializeField] private SmileScript smile;
    [SerializeField] private float minXpos, maxXpos;


    

    // Update is called once per frame
    void Update()
    {
        // Set the camera's position to track the X position of the "smile" game object within the specified range
        transform.position = new Vector3(Mathf.Clamp(smile.transform.position.x, minXpos, maxXpos), transform.position.y, transform.position.z);
    }
}
