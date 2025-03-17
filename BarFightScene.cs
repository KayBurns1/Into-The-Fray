using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    StoryBlock currentBlock; //keeps track of where the story currently is

    //blocks 1-10 tell the story
    static StoryBlock block10 = new StoryBlock("You begrudgingly accept so this fight won't happen again. You throw the first punch. The guy you punched kicks you back. What do you do?");
    static StoryBlock block9 = new StoryBlock("You refuse because you hate bar fights. One of them takes a swing at you. What do you do?");
    static StoryBlock block8 = new StoryBlock("You ignore them again. One of them takes a swing at you. What do you do?");
    static StoryBlock block6 = new StoryBlock("You wobble to your feet and look them in the eye. They tell you they don't know you and don't like the sight of you either. They demand a fight.", block8, block9, block10);
    static StoryBlock block7 = new StoryBlock("You don't feel like fighting right now.", block6, block6, block7);
    static StoryBlock block5 = new StoryBlock("");
    static StoryBlock block3 = new StoryBlock("You tell them to get lost. The bar goers grab you by the collar and throw you across the room!", block6, block6, block7);
    static StoryBlock block4 = new StoryBlock("You ignore them. The bar goers shout at you.", block5, block3, block3); 
    static StoryBlock block2 = new StoryBlock("You don't feel like fighting right now.", block4, block3, block2); 
    static StoryBlock block1 = new StoryBlock("You take a seat and order a drink, minding your own business. Suddenly, a group from the bar approach you", block4, block3, block2);


    void Start()
    {
        DisplayBlock(block1); //when the game first starts, display block 1
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
        DisplayBlock(currentBlock.fightBlock); //go to the block disignated by the fight option
    }

    //this function is for the action option and tells the game what to do when fight is picked
    public void ActionPicked()
    {
        DisplayBlock(currentBlock.actionBlock);//go to the block disignated by the action option
    }

    //this function is for the flight option and tells the game what to do when fight is picked
    public void FlightPicked()
    {
        DisplayBlock(currentBlock.flightBlock);//go to the block disignated by the flight option
    }
    
}
