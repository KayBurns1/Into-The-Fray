using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    //amount is sent from enemy script
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            //dead
            //play death animation
            //show game over screen?????
        }
    }

    void Heal(int gain)
    {
        currentHealth += gain;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

}
