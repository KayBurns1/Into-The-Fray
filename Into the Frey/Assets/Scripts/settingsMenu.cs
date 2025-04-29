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
    public Slider volumeSlider;

    void Start()
    {
        // Load the current volume from the mixer and apply it to the slider
        float currentVolume;
        if (mixer.GetFloat("volume", out currentVolume))
        {
            volumeSlider.value = currentVolume;
        }
    }
    //function to increase/decrease volume
    public void SetVolume(float volume)
    {
        //attach the mixer to an actual value
        mixer.SetFloat("volume", volume);
        Debug.Log($"Slider Value: {volume}");
        //Debug.Log(mixer.isPlaying);
    }

    //function to go back to the main menu
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}