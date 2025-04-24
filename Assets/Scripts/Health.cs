using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public EnemySpawner spawn;

    public GameObject popUpPrefab;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    //amount is sent from enemy script
    public void TakeDamage(int damage)
    {
        GameObject popUp = Instantiate(popUpPrefab, transform.position, Quaternion.identity);
        popUp.GetComponentInChildren<TextMesh>().text = damage.ToString();

        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            //dead
            //play death animation
            //show game over screen?????
            spawn.fight = false;
            //maybe reset the interval timers?????
            SceneManager.LoadScene("GameOver");
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
