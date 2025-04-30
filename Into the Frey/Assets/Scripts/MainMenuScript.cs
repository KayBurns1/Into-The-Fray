using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    //declaring all the buttons in the scene
    public Button play;
    public Button settings;
    public Button quit;
    //reference to the score script
    public Scoring score;

    //quit application function
    public void OnApplicationQuit()
    {
        //quit game
        Application.Quit();
    }
    public void Start()
    {
        //update the current score to be 0
        score.currentScore = 0;
    }
    //play function
    public void Play()
    {
        //load main game scene
        SceneManager.LoadScene(2);
    }

    //settings function
    public void Settings()
    {
        //load settings scene
        SceneManager.LoadScene(1);
    }
}
