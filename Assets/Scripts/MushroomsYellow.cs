using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MushroomsYellow : MonoBehaviour
{
    private int counter = 4;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check for collision with angry object
        if (collision.gameObject.tag == "Angry")
        {
            // Loop
            for (int i = 0; i < counter; i++)
            {
                // Instantiate a new instance of the collided angry object
                Instantiate(collision.gameObject);
                counter -= 1;
            }
            // Destroy the current game object (Yellow Mushroom)
            Destroy(gameObject);



        }


    }
}
