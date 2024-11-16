using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class Rally : MonoBehaviour
{

    public string rallyWinner;
    public bool rallyOver = false;
    private string lastHit;
    private int rallyHits = 0; //used to determine serving case 

    public Serving serving;



    void Start()
    {

    }

    void Update()
    {
        if (rallyOver)
        {
            //serve code

            rallyHits = 0;
            rallyOver = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (!rallyOver)
        {
            if (collision.gameObject.CompareTag("Racket 1"))
            {
                lastHit = "player1";
                rallyHits++;
                Debug.Log("R1");
            }
            else if (collision.gameObject.CompareTag("Racket 2"))
            {
                lastHit = "player2";
                rallyHits++;
                Debug.Log("R2");
            }


            /*
            1. Whether it is in or out (what court did it land on)
            2. Which player gets the point
            3. Who's racket hit the shuttle and where it ended up.
            */

            // Left court p1
            if (collision.gameObject.CompareTag("Left Court 1"))
            {
                Debug.Log("Collided with birdie: " + collision.gameObject.tag);
                // add more logic if needed
                // if player 2 is serving && their score is even, player1score++
                Score.AddPointToPlayer1();
                rallyOver = true;
            }
            // Right court p1
            else if (collision.gameObject.CompareTag("Right Court 1"))
            {
                Debug.Log("Collided with birdie: " + collision.gameObject.tag);
                Score.AddPointToPlayer2();
                rallyOver = true;

            }
            //Left Court p2
            else if (collision.gameObject.CompareTag("Left Court 2"))
            {
                Debug.Log("Collided with birdie: " + collision.gameObject.tag);
                Score.AddPointToPlayer1();
                rallyOver = true;
            }
            //Left Court p2
            else if (collision.gameObject.CompareTag("Right Court 2"))
            {
                Debug.Log("Collided with birdie: " + collision.gameObject.tag);
                Score.AddPointToPlayer1();
                rallyOver = true;
            }

            //outside court (point determined by who hit it outside)
            if (collision.gameObject.CompareTag("Big Red Court"))
            {
                Debug.Log("Collided with birdie: " + collision.gameObject.tag);
                if (lastHit == "player1")
                {
                    Score.AddPointToPlayer2();
                    rallyOver = true;
                }
                else if (lastHit == "player2")
                {
                    Score.AddPointToPlayer1();
                    rallyOver = true;
                }

            }
        }

    }
}
