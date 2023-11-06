using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmileScript : MonoBehaviour

{
    // Start is called before the first frame update

    [SerializeField] private float _speed = 8;
    [SerializeField] private float _speedJump = 10;

    // Velocity of the Rigidbody2D
    private Vector2 _velocity;
    private float _inputAxis;
    private bool _isJumping = false;


    private Rigidbody2D _myRigidBody;
    void Start()
    {
        // Retrieve the reference to the Rigidbody2D component attached to the game object
        _myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Handle horizontal movement
        HorizontalMove();
        // Check for jump input and initiate jump if not already jumping
        if (Input.GetKey(KeyCode.Space) && !_isJumping)
        {
            Jump();
            _isJumping = true;
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }
private void HorizontalMove()
    {
        // Get input axis for horizontal movement
        _inputAxis = Input.GetAxis("Horizontal");
        // Update the velocity of the Rigidbody2D for horizontal movement
        _myRigidBody.velocity = new Vector2(_inputAxis * _speed, _myRigidBody.velocity.y);




    }
    private void Jump()
    {
        // Apply upward force to the Rigidbody2D for jumping
        _myRigidBody.AddForce(Vector2.up * _speedJump);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check for collision with ground object and reset the jumping flag when colliding with the ground
        if (collision.gameObject.tag == "Ground")
        {
                _isJumping = false;
            
        }
    }
}
