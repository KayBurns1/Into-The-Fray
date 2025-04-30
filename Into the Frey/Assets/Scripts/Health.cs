using System.Collections;
using System.Collections.Generic;
//using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    private TopDownCharacterController controller;

    //start is called before the first frame update
    void Start()
    {
       currentHealth = maxHealth;
       controller = GetComponent<TopDownCharacterController>();
    }

    //amount is sent from enemy script
    public void TakeDamage(int damage)
    {
        if (controller != null && controller.IsBlinking)
        {
            // ignore damage while blinking
            return;
        }
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            //dead
            //play death animation
            SceneManager.LoadScene(5);
        }
    }

    public void Heal(int gain)
    {
        currentHealth += gain;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

}