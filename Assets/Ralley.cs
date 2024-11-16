using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class Ralley : MonoBehaviour
{

    public string ralleyWinner;
    public bool ralleyOver = false;
    private string lastHit;


    public Serving serving;



    void Start()
    {

    }

    void Update()
    {
        if (ralleyOver)
        {
            //serve 
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (!ralleyOver)
        {
            /*
            1. Whether it is in or out (what court did it land on)
            2. Which player gets the point
            3. Who's racket hit the shuttle and where it ended up.
            */
            if (collision.gameObject.CompareTag("Left Court 1"))
            {
                Debug.Log("Collided with birdie: " + collision.gameObject.tag);
                // add more logic if needed
                // if player 2 is serving && their score is even, player1score++
                Score.AddPointToPlayer1();
                ralleyOver = true;
            }
            else if (collision.gameObject.CompareTag("Right Court 1"))
            {
                Debug.Log("Collided with birdie: " + collision.gameObject.tag);
                // add more logic if needed
                Score.AddPointToPlayer2();
                ralleyOver = true;

            }
            else if (collision.gameObject.CompareTag("Left Court 2"))
            {
                Debug.Log("Collided with birdie: " + collision.gameObject.tag);
                // add more logic if needed
                Score.AddPointToPlayer1();
                ralleyOver = true;
            }
            else if (collision.gameObject.CompareTag("Right Court 2"))
            {
                Debug.Log("Collided with birdie: " + collision.gameObject.tag);
                // add more logic if needed
                Score.AddPointToPlayer1();
                ralleyOver = true;
            }

            if (collision.gameObject.CompareTag("Racket 1"))
            {
                lastHit = "player1";
                Debug.Log("R1");
            }
            else if (collision.gameObject.CompareTag("Racket 2"))
            {
                lastHit = "player2";
                Debug.Log("R2");
            }


            if (collision.gameObject.CompareTag("Big Red Court"))
            {
                Debug.Log("Collided with birdie: " + collision.gameObject.tag);
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
}
