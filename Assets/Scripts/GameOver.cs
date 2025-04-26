using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Button Restart;
    public EnemyHealth em;
    public int highScore;
    public Text highScoreDisplay;
    public Text currentScoreDisplay;

    public void Start()
    {
        if (em.killCount >= highScore)
        {
            highScore = em.killCount;
            highScoreDisplay.text = "High Score : " + highScore.ToString();
            currentScoreDisplay.text = "Current Score : " + em.killCount.ToString();
            em.killCount = 0;
        } else
        {
            highScoreDisplay.text = "High Score : " + highScore.ToString();
            currentScoreDisplay.text = "Current Score : " + em.killCount.ToString();
            em.killCount = 0;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
