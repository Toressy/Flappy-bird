using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyComponentScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check for collision with death object
        if (collision.gameObject.tag == "Death")
        {
            // Destroy the game object to which this script is attached
            Destroy(gameObject);
        }
    }
}
