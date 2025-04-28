using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Button Restart;
    public int highScore;
    public Text highScoreDisplay;
    public Text currentScoreDisplay;

    public Scoring score;

    public void Start()
    {
        if (score.currentScore >= highScore)
        {
            highScore = score.currentScore;
            highScoreDisplay.text = "High Score : " + highScore.ToString();
            currentScoreDisplay.text = "Current Score : " + score.currentScore.ToString();
            score.currentScore = 0;
        } else
        {
            highScoreDisplay.text = "High Score : " + highScore.ToString();
            currentScoreDisplay.text = "Current Score : " + score.currentScore.ToString();
            score.currentScore = 0;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
