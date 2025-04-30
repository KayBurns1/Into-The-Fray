using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlsScene : MonoBehaviour
{
    //decalring button for home screen
    public Button mainMenu;

    public void MainMenu()
    {
        //load home screen
        SceneManager.LoadScene(0);
    }
}
