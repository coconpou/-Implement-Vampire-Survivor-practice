using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScoreBoard : MonoBehaviour
{
    public static int playerScore1;
    public static int playerScore2;
    public TextMeshProUGUI showPlayer1Score;
    public TextMeshProUGUI showPlayer2Score;
    private void Awake()
    {
        playerScore1 = 0;
        playerScore2 = 0;
    }
    
    public void Update()
    {
        //playerScore1++;
        UpdateScore();
    } // plus point
 
    void UpdateScore()
    {
        showPlayer1Score.text = "Player1 Score: " + playerScore1.ToString();
        showPlayer2Score.text = "Player2 Score: " + playerScore2.ToString();
    } // update score
}
