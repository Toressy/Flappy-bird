using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectorScript : MonoBehaviour

{
    private int boneCount = 0;
    // Reference to the UI Text component to display the bone count
    [SerializeField] private Text bonesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check for collision with a bone object
        if (collision.gameObject.tag == "Bone")
        {
            Destroy(collision.gameObject);
            boneCount += 1;
            // Update the UI text
            bonesText.text = "Bones: " + boneCount;
        }
    }
}
