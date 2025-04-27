using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Button Restart;
    public int highScore;
    public int currentScore;
    public Text highScoreDisplay;
    public Text currentScoreDisplay;

    public void Start()
    {
        if (currentScore >= highScore)
        {
            highScore = currentScore;
            highScoreDisplay.text = "High Score : " + highScore.ToString();
            currentScoreDisplay.text = "Current Score : " + currentScore.ToString();
            currentScore = 0;
        } else
        {
            highScoreDisplay.text = "High Score : " + highScore.ToString();
            currentScoreDisplay.text = "Current Score : " + currentScore.ToString();
            currentScore = 0;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}