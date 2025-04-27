using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Collections.AllocatorManager;
using UnityEngine.SceneManagement;

//creates a class to store the story parts
class StoryBlock
{
    //setting variables for the main text and each option
    public string barDialogue;
    public StoryBlock fightBlock;
    public StoryBlock actionBlock;
    public StoryBlock flightBlock;

    //declare the function that actually prints the story to the screen
    public StoryBlock(string barDialogue, StoryBlock flightBlock = null, StoryBlock actionBlock = null, StoryBlock fightBlock = null)
    {
        this.barDialogue = barDialogue;
        this.fightBlock = fightBlock;
        this.actionBlock = actionBlock;
        this.flightBlock = flightBlock;
    }

}
public class BarFightScene : MonoBehaviour
{
    //setting variables for the text and interactible buttons
    public Text mainText;
    public Button fight;
    public Button action;
    public Button flight;

    //bool for if the scene is completed
    public bool dialogueCompleted = false;

    StoryBlock currentBlock; //keeps track of where the story currently is

    //blocks 0-12 tell the story
    static StoryBlock block12 = new StoryBlock("You apologize for inconviencing them, but they weren't willing to hear you out and swung again. You must fight for your honor.");
    static StoryBlock block11 = new StoryBlock("You try to ignore them again, but they keep swinging. This will not fly. You must fight for your honor.");
    static StoryBlock block10 = new StoryBlock("You begrudgingly accept so this fight won't happen again.");
    static StoryBlock block9 = new StoryBlock("You refuse because you hate fighting. They take a swing at you. You won't let this fly. You must fight for your honor, even if its the last thing you want to do.");
    static StoryBlock block8 = new StoryBlock("You ignore them again. They take a swing at you.", block11, block12);
    static StoryBlock block6 = new StoryBlock("You wobble to your feet and look them in the eye. They tell you they don't know you and don't like the sight of you either. They demand a fight.", block8, block9, block10);
    static StoryBlock block5 = new StoryBlock("You ignore them again and keep walking. Suddenly, the figure shoves you to the ground!", block6, block6);
    static StoryBlock block3 = new StoryBlock("You tell them to stop yelling and turn to talk again. They are right behind you now and grab you by the collar and toss you aside like you're nothing!", block6, block6);
    static StoryBlock block4 = new StoryBlock("You ignore them. The figure shouts again.", block5, block3, block3);
    static StoryBlock block1 = new StoryBlock("You approach the figure. You decide to introduce yourself. They say nothing. After a bit you walk away when they shout at you again.", block4, block3);
    static StoryBlock block0 = new StoryBlock("Left click the choice that you want to make, where you either fight, try to take action, or flee. Click any of the buttons to start.", block1, block1, block1);



    void Start()
    {
        DisplayBlock(block0); //when the game first starts, display block 1
    }
    
    //this function is how any block gets displayed
    void DisplayBlock(StoryBlock block)
    {
        mainText.text = block.barDialogue; //set the main text as the dialogue from the current block
        currentBlock = block; //update current block
    }

    //this function is for the fight option and tells the game what to do when fight is picked
    public void FightPicked()
    {
        if (currentBlock == block0)
        {
            DisplayBlock(currentBlock.fightBlock);//go to the block disignated by the fight option
        }
        else
        {
            //turn true to show thar the dialogue is done
            dialogueCompleted = true;
            //start fight scene
            SceneManager.LoadScene("SC Demo");
        }
    }

    //this function is for the action option and tells the game what to do when fight is picked
    public void ActionPicked()
    {
        //if dialogue is done
        if (currentBlock == block11 || currentBlock == block9 || currentBlock == block10)
        {
            //display current block
            DisplayBlock(currentBlock.actionBlock);
            //start coroutine to start fight
            StartCoroutine(FightTime());
            //Invoke("fightTime", 5);
        }
        else
        {
            DisplayBlock(currentBlock.actionBlock);//go to the block disignated by the action option
        }
    }

    //this function is for the flight option and tells the game what to do when fight is picked
    public void FlightPicked()
    {
        if (currentBlock == block11 || currentBlock == block9 || currentBlock == block10)
        {
            //display current block
            DisplayBlock(currentBlock.flightBlock);
            //start coroutine to start fight
            StartCoroutine(FightTime());
        }
        else { 
            DisplayBlock(currentBlock.flightBlock);//go to the block disignated by the flight option
        }
    }

    //starts fight scene
    private IEnumerator FightTime()
    {
        //wait for 5 seconds to let player read displayed
        yield return new WaitForSeconds(5);

        //turn true to show thar the dialogue is done
        dialogueCompleted = true;
        //start fight scene
        SceneManager.LoadScene("SC Demo");
    }

}
