using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Rally rally;
    public static int player1Score;
    public static int player2Score;
    // code for duece (win by two if 20-20)
    private bool winBy2;
    private bool GameOver;

    public static void AddPointToPlayer1()
    {
        player1Score++;
        Debug.Log(player1Score);
        Debug.Log(player2Score);
    }

    public static void AddPointToPlayer2()
    {
        player2Score++;
        Debug.Log(player1Score);
        Debug.Log(player2Score);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameOverChecker();
    }

    public void gameOverChecker()
    {
        //if either player is at 21 or more and the differnce between them is atleast 2 or more 
        if ((Mathf.Abs(player1Score - player2Score) >= 2) && ((player1Score >= 21) || (player2Score >= 21)))
        {
            if (player1Score > player2Score)
            {
                Debug.Log("Player 1 Wins!");
            }
            else
            {
                Debug.Log("Player 2 Wins!");
            }
        }
    }
}
