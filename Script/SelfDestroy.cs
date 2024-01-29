using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelfDestroy : MonoBehaviour
{
    [SerializeField] private Transform magicMissile ;
    private int score = PlayerScoreBoard.playerScore1;
    public void Destroy()
    {
        //Debug.Log(magicMissile.tag);
        if (magicMissile.tag == "player1")
        {
            PlayerScoreBoard.playerScore1++;
            //Debug.Log("player1 Score: " + ScoreBoardPlayer1.playerScore1);
        } // if
        else if ( magicMissile.tag == "player2" )
        {
            PlayerScoreBoard.playerScore2++;
            //Debug.Log("player2 Score: " + ScoreBoardPlayer1.playerScore2);
        } // else if 

        
        Destroy(gameObject);
       
    }


}
