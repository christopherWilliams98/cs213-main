using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FindWinner : MonoBehaviour
{
    public static TextMeshProUGUI winner;

public void Start() {
        winner = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    public static void winnerText(){
        if(Scoreboard.player1Score > Scoreboard.player2Score){
            winner.text = "PURPLE TEAM!";
            winner.color = new Color32(255, 95, 206,255);
        }else if(Scoreboard.player1Score < Scoreboard.player2Score){
            winner.text = "BLUE TEAM!";
            winner.color = new Color32(24, 60, 245,255);
        }
        else{
            winner.text = "IT'S A DRAW!";
            winner.color = new Color32(4, 20, 5, 255); 
        }
    }

}
