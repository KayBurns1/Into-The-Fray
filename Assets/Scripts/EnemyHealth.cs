using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    private GameObject FloatingText; //floating text var for pop up damage
    public int maxHealth; //var to keep track of max health
    public int currentHealth; //var to keep track of current health

    //reference to score script
    public Scoring score;

    
    // Start is called before the first frame update
    void Start()
    {
        //make sure the current health is the max health when starting
        currentHealth = maxHealth;
    }

    //function to take damage
    public void TakeDamage(int damage)
    {
        //decrease the current health by damage amount and sent the current health to that number
        currentHealth -= damage;

        //display floating text if it exists
        if (FloatingText != null)
        {
            ShowFloatingText();
        }

        //when dead if statement
        if (currentHealth <= 0)
        {
            //maybe play death animation????
            Destroy(gameObject); //delete current object/enemy
            score.currentScore += 1; //increase score by 1
            return;
        }
    }

    //function to show the pop up text
    void ShowFloatingText()
    {
        //display text and store it in a var
        var show = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
        show.GetComponentInChildren<TextMesh>().text = currentHealth.ToString(); //show prev var
    }
    

}
