using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    //var to keep track if the game is paused
    public static bool gamePaused = false;

    //for the UI
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        //check if escape was pressed for the pause menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //check if game is paused
            if (gamePaused)
            {
                //resume if true
                Resume();
            } else
            {
                //pause if false
                Paused();
            }
        }
    }

    //resume function
    public void Resume()
    {
        //remove pause menu UI
        pauseMenuUI.SetActive(false);
        //resume time
        Time.timeScale = 1f;
        //turn gamePaused to false so we know to pause next time
        gamePaused = false;
    }

    //pause function
    void Paused()
    {
        //bring up the pause menu UI
        pauseMenuUI.SetActive(true);
        //freeze time
        Time.timeScale = 0f;
        //turn gamePaused to true so we know to resume next time
        gamePaused = true;
    }

    //function to load settings from button
    public void Settings()
    {
        //loads settings scene
        SceneManager.LoadScene("Settings");
    }

    //function to load menu from button
    public void MainMenu()
    {
        //loads menu scene
        SceneManager.LoadScene("MainMenu");
    }
}
