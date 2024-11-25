using System.Collections;
using System.Collections.Generic;
using Oculus.Platform;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 3.0f; // movement speed
    public Transform vrCamera; // reference to VR camera (CenterEyeAnchor)
    // Start is called before the first frame update
    void Start()
    {
        // make sure VR camera reference is set
        if (vrCamera == null) 
            vrCamera = Camera.main.transform; // main camera is defaulted
        
    }

    // Update is called once per frame
    void Update()
    {
        // get joystick input
        Vector2 joystickInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);   

        // if joystick is idle, do nothing
        if (joystickInput.sqrMagnitude < 0.01f) 
            return;

            // calculate forward and right direction based on teh camera's orientation
            Vector3 forward = vrCamera.forward;
            Vector3 right = vrCamera.right;

            // flatten the forward and right vectors
            forward.y = 0;
            right.y = 0;

            // normalize to ensure conssisten movement
            forward.Normalize();
            right.Normalize();

            // calculate the movement direction
            Vector3 movement = (forward * joystickInput.y + right * joystickInput.x) * speed * Time.deltaTime;

            // apply movement to the player GameObject
            transform.position += movement;
    }
}
