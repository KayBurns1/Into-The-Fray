using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer mixer;
    public Button menu;

    public void SetVolume(float volume)
    {
        mixer.SetFloat("volume", volume);
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
