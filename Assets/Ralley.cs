using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


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
    private string lastHit;
    private bool serving;



    void Start()
    {

    }

    void Update()
    {
        checkGameEnd();
    }


    //this method contantly checks if game is over and the case of winBy2
    void checkGameEnd()
    {
        
    }


    //this method checks if score is even or odd, reset the birdie to hand, reset each players location to correct court
    void serve(string server)
    {
        //if (Score.isOdd())
        {
            // serve from left court 1 (player 2's serve) or left court 2 (player 1's serve)
        }
        //else if (Score.isEven()) 
        {
            // serve from right court 1 (player 2's serve) or right court 2 (player 1's serve) 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Left Court 1"))
        {
            Debug.Log("Collided with birdie: " + collision.gameObject.tag);
            // add more logic if needed
            // if player 2 is serving && their score is even, player1score++
            Player2Score++;
            serve("player2");
 
            
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
            Player2Score++;
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
            Player1Score++;
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
            Player1Score++;
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
                Player2Score++;
                Debug.Log(Player2Score);
            }
            else if (lastHit == "player2")
            {
                Player1Score++;
                Debug.Log(Player1Score);
            }

            /*
            1. Whether it is in or out.
            2. Which player gets the point
            3. Who's racket hit the shuttle and where it ended up.
            4. Resetting it
            */

            
        }

    }
}
