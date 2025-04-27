using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxHealth; //var to keep track of max health
    public int currentHealth; //var to keep track of current health

    //reference to enemy spawner and dialogue scripts
    public EnemySpawner spawn;
    public BarFightScene fight;

    //referense to pop up text prefab
    public GameObject popUpPrefab;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; //make sure the current health is the max health when starting
    }

    //amount is sent from enemy script
    public void TakeDamage(int damage)
    {
        //show how much damage enemy does with a pop up text
        GameObject popUp = Instantiate(popUpPrefab, transform.position, Quaternion.identity);
        popUp.GetComponentInChildren<TextMesh>().text = damage.ToString();

        //decrease current health by a damage amount
        currentHealth -= damage;
        //dead if current health is below 0
        if (currentHealth <= 0)
        {
            //play death animation
            //make sure enemies stop spawning
            spawn.fight = false;
            //make sure you can complete dialogue again when game restarts
            fight.dialogueCompleted = false;
            //load game over screen
            SceneManager.LoadScene("GameOver");
        }
    }

    //healing refrence
    public void Heal(int gain)
    {
        //increase health by gain amount
        currentHealth += gain;
        if (currentHealth > maxHealth)
        {
            //make sure the current health cannot be more than max health
            currentHealth = maxHealth;
        }
    }

}
