using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomScript : MonoBehaviour
{
    private int counter;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check for collision with angry object
        if (collision.gameObject.tag == "Angry")
        {
            // Loop
            counter = 5;
            while(counter > 0)
            {
               Instantiate(collision.gameObject);
                counter -= 1;
            }
            // Destroy the current game object (Mushroom 1)
            Destroy(gameObject);
 

        }

    }
            

}
