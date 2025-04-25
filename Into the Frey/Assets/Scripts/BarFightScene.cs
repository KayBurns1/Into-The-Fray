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

    StoryBlock currentBlock; //keeps track of where the story currently is

    //blocks 0-17 tell the story
    static StoryBlock block13 = new StoryBlock("You try to talk to them but they hit you over the head with some sort of club, which is the last thing you see before crumpling to the ground."); 
    static StoryBlock block12 = new StoryBlock("You decide you don't want to fight anymore. You turn and run, but they sweep you off your feet and you hit the ground face first. The last thing you remember is getting on all fours, then a thump on your head.");
    static StoryBlock block17 = new StoryBlock("No matter what you try to do, you cannot escape his death grip on your hand. Someone else hits you on the head from behind, and the last thing you see is his smirk, knowing he won.");
    static StoryBlock block16 = new StoryBlock("You try his face again, yet he anticipates it and grabs your fist instead.", block17, block17, block17);
    static StoryBlock block15 = new StoryBlock("You aim for his face again but he blocks it this time with his arm. He gets your stomach, and you double over in pain.", block12, block13, block16);
    static StoryBlock block14 = new StoryBlock("You stand back up and punch him in the face. A trickle of blood drips down his nose that he quickly sniffles away. He aims his next blow straight for your gut", block12, block13, block15);
    static StoryBlock block11 = new StoryBlock("You stand your ground and throw another punch to the gut. He swings again but this time you see it coming and duck.", block12, block13, block14);
    static StoryBlock block10 = new StoryBlock("You begrudgingly accept so this fight won't happen again. You throw the first punch. They kick you back.", block12, block13, block11);
    static StoryBlock block9 = new StoryBlock("You refuse because you hate fighting. They take a swing at you.", block12, block13, block11);
    static StoryBlock block8 = new StoryBlock("You ignore them again. They take a swing at you.", block12, block13, block11);
    static StoryBlock block6 = new StoryBlock("You wobble to your feet and look them in the eye. They tell you they don't know you and don't like the sight of you either. They demand a fight.", block8, block9, block10);
    static StoryBlock block7 = new StoryBlock("You don't feel like fighting right now.", block6, block6, block7);
    static StoryBlock block5 = new StoryBlock("You ignore them again and keep walking. Suddenly, the figure shoves you to the ground!", block6, block6, block7);
    static StoryBlock block3 = new StoryBlock("You tell them to stop yelling and turn to talk again. They are right behind you now and grab you by the collar and toss you aside like you're nothing!", block6, block6, block7);
    static StoryBlock block4 = new StoryBlock("You ignore them. The figure shouts again.", block5, block3, block3); 
    static StoryBlock block2 = new StoryBlock("You don't feel like fighting right now.", block4, block3, block2); 
    static StoryBlock block1 = new StoryBlock("You approach the figure. You decide to introduce yourself. They say nothing. After a bit you walk away when they shout at you again.", block4, block3, block2);
    static StoryBlock block0 = new StoryBlock("Left click the choice that you want to make, where you either fight, try to take action, or flee. Click and of the buttons to start.", block1, block1, block1);

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
    
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
        SceneManager.LoadScene("SC Demo");
        }
    }

}
