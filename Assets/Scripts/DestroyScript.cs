using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyScript : MonoBehaviour
{
    private Rigidbody2D _myRigidBody;
    private void Start()
    {
        //retrieve the reference to the Rigidbody2D component attached to the game object 
        _myRigidBody = GetComponent<Rigidbody2D>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check for collision with death object
        if (collision.gameObject.tag == "Death")
        {
            Restart();
        }
    }

    private void Restart()
    {
        // Restart the scene by loading the current scene again
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
