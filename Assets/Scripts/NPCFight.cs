using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCFight : MonoBehaviour, IInteractable
{
    //this is the script for the NPC that starts the fight dialogue scene

    public bool Talked { get; private set; }
    public string NPCID {  get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        NPCID ??= GlobalHelper.GenerateUniqueID(gameObject);
    }

    public bool CanInteract()
    {
        return !Talked;
    }

    public void Interact()
    {
        if (!CanInteract()){
            return;
        }

        SceneManager.LoadScene("BarFight");

    }
}
