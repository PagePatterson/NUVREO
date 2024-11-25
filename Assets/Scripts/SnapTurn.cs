using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapTurn : MonoBehaviour
{
    public Transform rightTransform;
    public float turnAngle = 45f;
    public float deadzone = 0.3f;
    public float cooldownTime = 0.2f;

    private float lastTurnTime = 0f;

    void Update()
    {
        // Get the horizontal input from the RIGHT joystick (SecondaryThumbstick)
        Vector2 joystickInput = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick); // Right joystick

        if (Time.time - lastTurnTime > cooldownTime)
        {
            // Check if the input is above the deadzone to trigger snap turn
            if (joystickInput.x > deadzone) // Turn right
            {
                Snap(1);
                lastTurnTime = Time.time;
            }
            else if (joystickInput.x < -deadzone) // Turn left
            {
                Snap(-1);
                lastTurnTime = Time.time;
            }
        }
    }

    void Snap(int direction)
    {
        rightTransform.Rotate(0, direction * turnAngle, 0); // Rotate around the Y-axis
    }
}
