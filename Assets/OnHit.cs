using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHit : MonoBehaviour
{
    public float hitForce = 0.5f;  // Adjust this value for the desired strength

    // Optionally, you can tweak this to apply force in a more realistic manner.
    public float directionFactor = 1f;  // How strongly to influence the ball's direction.

    // The amount of spin to apply to the ball
    public float spinForce = 0.001f;  // Adjust this value to control the ball spin

    // Detect when the ball collides with the racket
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object collided with is the ball (you can tag it for more precision)
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Get the Rigidbody component of the ball
            Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            if (ballRigidbody != null)
            {
                // Calculate the direction of the hit (normal of the collision surface)
                Vector3 hitDirection = collision.contacts[0].normal;

                // Apply a force to the ball in the direction of the hit
                ballRigidbody.AddForce(hitDirection * hitForce * directionFactor, ForceMode.Impulse);

                // Apply spin to the ball (rotate around an axis)
                Vector3 spinDirection = transform.up; // This assumes the racket's up direction gives a good axis for spin
                ballRigidbody.AddTorque(spinDirection * spinForce, ForceMode.Impulse);
            }
        }
    }
}
