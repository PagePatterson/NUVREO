using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Serving : MonoBehaviour
{

    //even right side 
    //odd left side
    //winner always serve

    //if player lets go of finger, ralley has started
    private string server;
    private bool ralleyStart;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
}
