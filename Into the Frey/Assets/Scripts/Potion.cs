using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPotion : MonoBehaviour
{
    public int healAmount = 25; // How much health to restore

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the colliding object has a PlayerHealth component
        Health player = collision.GetComponent<Health>();

        if (player != null)
        {
            player.Heal(healAmount);
            Destroy(gameObject); // Destroy the potion after healing
            //Debug.Log("Destroying: " + gameObject.name);
        }
    }
}
