using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCFight : MonoBehaviour, IInteractable
{
    //this is the script for the NPC that starts the fight dialogue scene

    public bool Talked { get; private set; } //set bool for if NPC was talked to yet or not
    public string NPCID {  get; private set; } //create var to keep track of NPC id


    // Start is called before the first frame update
    void Start()
    {
        //declare NPC id if it doesnt exist
        NPCID ??= GlobalHelper.GenerateUniqueID(gameObject);
    }

    public bool CanInteract()
    {
        //make sure it is not interacted at first
        return !Talked;
    }

    public void Interact()
    {
        //make sure it cant interact if it is not interacted yet
        if (!CanInteract()){
            return;
        }

        //if it can interact make sure to load the dialogue scene
        SceneManager.LoadScene("BarFight");

    }
}
