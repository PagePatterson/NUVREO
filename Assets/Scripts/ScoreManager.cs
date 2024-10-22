using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int score = 0;

    public Text scoreText;

    void Awake()
    {
        if (Instance == null )
        {
            Instance = this;
        }
    }

    public void UpdateScore()
    {
        score += 1;
        
        scoreText.text = "Score: " + score + "/10";

        Debug.Log("Score: " + score + "/10");
    }
 
}
