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
    public AudioSource audio; //audio source to mute

    //function to increase/decrease volume
    public void SetVolume(float volume)
    {
        //attach the mixer to an actual value
        mixer.SetFloat("volume", volume);
    }

    //function to go back to the main menu
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Mute(bool mute)
    {
        if(mute)
        {
            AudioListener.volume = -80;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }
}
