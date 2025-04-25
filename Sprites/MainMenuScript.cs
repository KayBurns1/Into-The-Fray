using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    
    public Button play;
    public Button quit;
    public EnemyHealth em;

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void Play()
    {
        em.killCount = 0;
        SceneManager.LoadScene("SC Demo");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
}
