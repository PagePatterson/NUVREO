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
    }

    public static void AddPointToPlayer2()
    {
        player2Score++;
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreUI();
        ClearResultMessage();
    }

    // Update is called once per frame
    void Update()
    {
         if (scoreText != null) {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    public void gameOverChecker() {
        if (abs(player1Score - player2Score) >= 2 and (player1Score >= 21 or player2Score >= 21)) {
            if (player1Score > player2Score) {
                DisplayResultMessage("Player 1 Wins!")
            }
            else {
                DisplayResulMessage("Player 2 Wins!");
            }
        }
    }
}
