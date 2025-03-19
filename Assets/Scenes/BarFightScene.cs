using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class StoryBlock
{

    public string barDialogue;
    public StoryBlock fightBlock;
    public StoryBlock actionBlock;
    public StoryBlock flightBlock;

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
    // Start is called before the first frame update
    public Text mainText;
    public Button fight;
    public Button action;
    public Button flight;

    StoryBlock currentBlock;

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
        DisplayBlock(block1);
    }
    void DisplayBlock(StoryBlock block)
    {
        mainText.text = block.barDialogue;
        currentBlock = block;
    }
    public void FightPicked()
    {
        DisplayBlock(currentBlock.fightBlock);
    }

    public void ActionPicked()
    {
        DisplayBlock(currentBlock.actionBlock);
    }

    public void FlightPicked()
    {
        DisplayBlock(currentBlock.flightBlock);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
