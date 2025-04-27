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

    //play function
    public void Play()
    {
        //update the current score to be 0
        score.currentScore = 0;
        //load main game scene
        SceneManager.LoadScene("SC Demo");
    }

    //settings function
    public void Settings()
    {
        //load settings scene
        SceneManager.LoadScene("Settings");
    }
}
