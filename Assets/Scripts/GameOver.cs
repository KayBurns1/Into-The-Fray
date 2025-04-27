using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{   
    public Button Restart; //button to take you back to the main menu
    public int highScore; //var to keep track of high score
    public Text highScoreDisplay; //text to show high score
    public Text currentScoreDisplay; //text to show current score

    //reference to scoring script
    public Scoring score;

    public void Start()
    {
        //if current score is higher than high score
        if (score.currentScore >= highScore)
        {
            //set high score to be current score and display the two
            highScore = score.currentScore;
            highScoreDisplay.text = "High Score : " + highScore.ToString();
            currentScoreDisplay.text = "Current Score : " + score.currentScore.ToString();
            score.currentScore = 0; //reset the current score
        } else
        {
            //display high score and current score
            highScoreDisplay.text = "High Score : " + highScore.ToString();
            currentScoreDisplay.text = "Current Score : " + score.currentScore.ToString();
            score.currentScore = 0; //reset the current score
        }
    }

    //go back to the main menu
    public void Restarting()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
