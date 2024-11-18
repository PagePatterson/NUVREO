using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 3.0f; // Speed of movement
    public Transform vrCamera; // Reference to the VR camera (usually CenterEyeAnchor)

    private void Start()
    {
        // Ensure the VR camera reference is set
        if (vrCamera == null)
            vrCamera = Camera.main.transform; // Default to the main camera
    }

    private void Update()
    {
        // Get joystick input
        Vector2 joystickInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);


        // If joystick is idle, do nothing
        if (joystickInput.sqrMagnitude < 0.01f)
            return;

        // Calculate forward and right directions based on the camera's orientation
        Vector3 forward = vrCamera.forward;
        Vector3 right = vrCamera.right;

        // Flatten the forward and right vectors
        forward.y = 0;
        right.y = 0;

        // Normalize to ensure consistent movement
        forward.Normalize();
        right.Normalize();

        // Calculate the movement direction
        Vector3 movement = (forward * joystickInput.y + right * joystickInput.x) * speed * Time.deltaTime;

        // Apply movement to the player GameObject
        transform.position += movement;
    }
}
