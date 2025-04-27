using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    
    public AudioMixer mixer; //var for the mixer to increase/decrease volume
    public Button menu; //menu button to go back

    //function to increase/decrease volume
    public void SetVolume(float volume)
    {
        //attach the mixer to an actual value
        mixer.SetFloat("volume", volume);
    }

    //function to go back to the main menu
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
