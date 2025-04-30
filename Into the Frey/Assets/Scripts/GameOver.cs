using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Button Restart;
    public int highScore;
    public Text highScoreText;
    public Text currentScoreText;

    public ScoreManager score;

    public void Start()
    {
            // Ensure high score is updated before displaying
            ScoreManager.instance.CheckAndSetHighScore();

            currentScoreText.text = $"Score: {ScoreManager.instance.GetScore()}";
            highScoreText.text = $"High Score: {ScoreManager.instance.GetHighScore()}";
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
