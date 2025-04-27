using UnityEngine;
using UnityEngine.UI;

public class tutorialSign : MonoBehaviour, IInteractable
{
    public bool IsInteractable { get; private set; }
    public string SignID { get; private set; }
    public GameObject itemPrefab;

    public GameObject tutorialPopup; // Reference to the popup UI element (this could be a Panel)
    public Text tutorialText; // Text field where the tutorial message will be displayed
    public string tutorialMessage; // The message to display in the tutorial

    void Start()
    {
        SignID ??= GlobalHelper.GenerateUniqueID(gameObject);

        if (tutorialPopup != null)
        {
            tutorialPopup.SetActive(false);
        }
    }

    public bool CanInteract()
    {
        return !IsInteractable;
    }

    public void Interact()
    {
        if (!CanInteract()) return;

        // Display the tutorial pop-up
        ShowTutorial();

        // Mark the sign as interacted with (if you don't want to show the tutorial multiple times)
        IsInteractable = true;    
    }
    
    void ShowTutorial()
    {
        if (tutorialPopup != null && tutorialText != null)
        {
            tutorialPopup.SetActive(true);  // Show the popup
            tutorialText.text = tutorialMessage; // Set the tutorial message

            // Optionally, hide the tutorial after some time
            Invoke("HideTutorial", 10f); // Hides the tutorial after 5 seconds (you can adjust the time)
        }
    }

    void HideTutorial()
    {
        if (tutorialPopup != null)
        {
            tutorialPopup.SetActive(false);  // Hide the popup
        }
    }
}
