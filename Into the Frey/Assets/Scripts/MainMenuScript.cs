using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    
    public Button play;
    public Button quit;

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene("SC Demo");
    }
}
