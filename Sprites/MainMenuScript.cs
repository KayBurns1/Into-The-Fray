using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene("SC Demo");
    }

    public void Settings()
{
    SceneManager.LoadScene("Settings");
}
}
