using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    //enemy objects
    [SerializeField]
    private GameObject swordSwarmer;
    [SerializeField]
    private GameObject rangedSwarmer;

    //player target
    public Transform target;

    //how much damage can be done
    public int damage;
    //reference to player health
    public Health playerHealth;

    //reference to enemy movement
    public EnemyMovement movement;

    //how often range enemy shoots
    public float fireRate;
    //var to keep track of when the range enemy can shoot
    public float timeToFire;

    //idk i forgor
    public Transform fireingPoint;

    private void Update()
    {
        //shoot if enemy is rangedSwarmer
        if (rangedSwarmer)
        {
            Shoot();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collide and cause damage if swordSwarmer collides with player
        if (swordSwarmer)
        {
            if (collision.gameObject.tag == "Player")
            {
                playerHealth.TakeDamage(damage);
            }
        }
    }

    private void Shoot()
    {
        //shoot when time or else subtract
        if (timeToFire <= 0f)
        {
            //shoot
            timeToFire = fireRate;
        } else
        {
            timeToFire -= Time.deltaTime;
        }
    }

}
