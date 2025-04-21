using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SignInteractable : MonoBehaviour
{
    //this is the script for the NPC that starts the fight dialogue scene

    public bool Interacted { get; private set; }
    public string SignID { get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        SignID ??= GlobalHelper.GenerateUniqueID(gameObject);
    }

    public bool CanInteract()
    {
        return !Interacted;
    }

    public void Interact()
    {
        if (!CanInteract())
        {
            return;
        }

        

    }
}
