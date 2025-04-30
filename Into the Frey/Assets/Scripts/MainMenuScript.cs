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
    public Button controls;
    public Button menu;
    //quit application function
    public void OnApplicationQuit()
    {
        //quit game
        Application.Quit();
    }

    //play function
    public void Play()
    {
        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.ResetScore();
        }
        SceneManager.LoadScene(2);
    }

    //settings function
    public void Settings()
    {
        //load settings scene
        SceneManager.LoadScene(1);
    }

    public void Controls()
    {
        //load controls scene
        SceneManager.LoadScene(5);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
