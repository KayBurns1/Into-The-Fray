using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void Resume()
    {
        int previousLevel = PlayerPrefs.GetInt("previousLevel");
        SceneManager.LoadScene(previousLevel);
    }

    public void OnApplicationQuit()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
}
