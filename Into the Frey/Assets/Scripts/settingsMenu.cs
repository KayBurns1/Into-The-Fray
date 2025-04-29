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
        float dB;

        if (volume == 0)
        dB = -80f; // -80 dB is basically mute
        else
        dB = Mathf.Log10(volume) * 20f;

        //attach the mixer to an actual value
        mixer.SetFloat("volume", dB);
        Debug.Log($"Slider Value: {volume} -> dB: {dB}");    
    }

    //function to go back to the main menu
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}