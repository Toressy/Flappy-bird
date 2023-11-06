using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSticky : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if we touched our player
        if (collision.gameObject.name == "Smile")
        {
            //Make our player move with platform
            collision.gameObject.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Smile")
        {
            // Remove our player from parent
            collision.gameObject.transform.SetParent(null);
        }

    }
}
