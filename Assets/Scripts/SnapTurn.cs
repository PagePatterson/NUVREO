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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickHorizontal");
        if (Time.time - lastTurnTime > cooldownTime) {
            if (horizontalInput > deadzone) {
                Snap(1);
                lastTurnTime = Time.time;
            }
            else if (horizontalInput < -deadzone) {
                Snap(-1);
                lastTurnTime = Time.time;
            }
        }
    }

    void Snap(int direction) {
        rightTransform.Rotate(0, direction * turnAngle, 0);
    }
}
