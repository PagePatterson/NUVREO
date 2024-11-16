using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class Ralley : MonoBehaviour
{

    public string ralleyWinner;
    public bool ralleyOver;
    private string lastHit;

    public Serving serving;



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
            // if player 2 is serving && their score is even, player1score++
            Score.AddPointToPlayer1();
            ralleyOver = true;
 
            
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
            Score.AddPointToPlayer2();
            ralleyOver = true;
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
            Score.AddPointToPlayer1();
            ralleyOver = true;
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
            Score.AddPointToPlayer1();
            ralleyOver = true;
            /*
            1. Whether it is in or out.
            2. Which player gets the point
            3. Who's racket hit the shuttle and where it ended up.
            4. Resetting it
            */

        }

        if (collision.gameObject.CompareTag("Racket 1"))
        {
            lastHit = "player1";
            Debug.Log("R1");
            // increase player 2's score by 1
            // out
            // set variable to variable 1
        }
        else if (collision.gameObject.CompareTag("Racket 2"))
        {
            lastHit = "player2";
            Debug.Log("R2");
            // increase player 1's score by 1
            // out
            // set variable to variable 1
        }
        
        
        if (collision.gameObject.CompareTag("Big Red Court"))
        {
            Debug.Log("Collided with birdie: " + collision.gameObject.tag);
            // add more logic if needed
            
            //if lasgtHit == player1, player2 gets point
            //if lasthit == player2, player1 gets point 
            if (lastHit == "player1")
            {
                Score.AddPointToPlayer2();
                ralleyOver = true;
            }
            else if (lastHit == "player2")
            {
                Score.AddPointToPlayer1();
                ralleyOver = true;
            }



            
        }

    }
}
