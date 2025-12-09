using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    // Speed of the player movement
    public float speed = 6f;

    // Reference to the player's Rigidbody component
    private Rigidbody rb;

    void Start()
    {
        // Get and store the Rigidbody attached to the player
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()

    {  // Get input from WASD or arrow keys
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Create a movement vector based on input
        Vector3 movement = new Vector3(h, 0, v) * speed;

        // Move the player using Rigidbody physics
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
    }
}

        
