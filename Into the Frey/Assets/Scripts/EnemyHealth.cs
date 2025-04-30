using System.Collections;
using System.Collections.Generic;
//using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        //Debug.Log($"Damage: {currentHealth} - {damage}");
      
        if (currentHealth <= 0)
        {
            //maybe play death animation????
            Destroy(gameObject);
            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.AddScore(1); //hardcoded to update score instance
            }
        }
            return;
    }
}

    /*void ShowFloatingText()
    {
        var show = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
        show.GetComponentInChildren<TextMesh>().text = currentHealth.ToString();
<<<<<<< HEAD
    }*/