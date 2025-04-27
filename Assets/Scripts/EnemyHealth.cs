using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private GameObject FloatingText;
    public int maxHealth;
    public int currentHealth;

    public GameOver end;

    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (FloatingText != null)
        {
            ShowFloatingText();
        }

        if (currentHealth <= 0)
        {
            //maybe play death animation????
            Destroy(gameObject);
            end.currentScore += 1;
            return;
        }
    }

    void ShowFloatingText()
    {
        var show = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
        show.GetComponentInChildren<TextMesh>().text = currentHealth.ToString();
    }
    

}
