using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDetector : MonoBehaviour
{
    //track closest interactable
    private IInteractable interactableInRange = null;
    public GameObject interactionIcon;

    // Start is called before the first frame update
    void Start()
    {
        //make sure interaction icon is not triggered on
        interactionIcon.SetActive(false);
    }

    public void OnInteract()
    {
        if (Input.GetKey(KeyCode.E))
        {
            //make sure the interactable is in range before interacting
            interactableInRange?.Interact();
        }
    }

    //function for making sure the player is in range with interactable object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IInteractable interactable) && interactable.CanInteract())
        {
            //show that the object is interactable
            interactableInRange = interactable;
            //show the interaction icon to let player know they are in range of an interactble object
            interactionIcon.SetActive(true);
        }
    }

    //function to make sure that the interactable is no longer interable when not in range
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IInteractable interactable) && interactable == interactableInRange)
        {
            //set the interactble in range to null to show it is not interactable
            interactableInRange = null;
            //toggle the interaction icon off to show player they are no longer in range of an interacbable object
            interactionIcon.SetActive(false);
        }
    }
}
