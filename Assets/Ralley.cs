using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ralley : MonoBehaviour
{
    private int Player1Score;
    private int Player2Score;
    private bool RalleyOver;
    private bool Service;
    // even number - right side
    // odd number - left side
    public bool GameOver;
    // code for duece (win by two if 20-20)
    public bool winBy2;



    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Left Court 1"))
        {
            Debug.Log("Collided with birdie: " + collision.gameObject.tag);
            // add more logic if needed

            /*
            1. Whether it is in or out.
            2. Which player gets the point
            3. Who's racket hit the shuttle and where it ended up.
            4. Resetting it
            */
        } 
        else if (collision.gameObject.CompareTag("Right Court 1"))
        {
            Debug.Log("Collided with birdie: " + collision.gameObject.tag);
            // add more logic if needed

            /*
            1. Whether it is in or out.
            2. Which player gets the point
            3. Who's racket hit the shuttle and where it ended up.
            4. Resetting it
            */
        }
        else if (collision.gameObject.CompareTag("Left Court 2"))
        {
            Debug.Log("Collided with birdie: " + collision.gameObject.tag);
            // add more logic if needed

            /*
            1. Whether it is in or out.
            2. Which player gets the point
            3. Who's racket hit the shuttle and where it ended up.
            4. Resetting it
            */
        }
        else if (collision.gameObject.CompareTag("Right Court 2"))
        {
            Debug.Log("Collided with birdie: " + collision.gameObject.tag);
            // add more logic if needed

            /*
            1. Whether it is in or out.
            2. Which player gets the point
            3. Who's racket hit the shuttle and where it ended up.
            4. Resetting it
            */
        }
    }
}
