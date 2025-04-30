using UnityEngine;
using UnityEngine.SceneManagement;

public class settingsMenu : MonoBehaviour
{
    public void backToGame()
    {
        SceneManager.LoadScene("PauseMenu");
    }
}
