using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SignInteractable : MonoBehaviour
{

    public bool Interacted { get; private set; } //set bool for if sign is interacted or not
    public string SignID { get; private set; } //create var to keep track of sign id


    // Start is called before the first frame update
    void Start()
    {
        //declare sign id if it doesnt exist
        SignID ??= GlobalHelper.GenerateUniqueID(gameObject);
    }

    public bool CanInteract()
    {
        //make sure it is not interacted at first
        return !Interacted;
    }

    public void Interact()
    {
        //make sure it cant interact if it is not interacted yet
        if (!CanInteract())
        {
            return;
        }

        

    }
}
