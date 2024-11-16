using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Ralley ralley;
    public static int player1Score;
    public static int player2Score;
    // code for duece (win by two if 20-20)
    private bool winBy2;
    private bool GameOver;

    public static void AddPointToPlayer1()
    {
        player1Score++;
    }

    public static void AddPointToPlayer2()
    {
        player2Score++;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
