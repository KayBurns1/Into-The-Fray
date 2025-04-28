using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D projectileRb;
    public float speed;
    public float projectileLife;
    public float damage;
    private float projectileCount;
    private Vector2 moveDirection;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        projectileCount = projectileLife;
        projectileRb.linearVelocity = moveDirection * speed;

        // Rotate the projectile to face the direction it's moving
        float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 270));

        Collider2D playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
        Collider2D myCollider = GetComponent<Collider2D>();
        Physics2D.IgnoreCollision(myCollider, playerCollider);
    }

    // Update is called once per frame
    void Update()
    {

        projectileCount -= Time.deltaTime;
        if(projectileCount <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void SetDirection(Vector2 direction)
    {
        moveDirection = direction.normalized;
    }

  /*private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHealth enemyHealth = collision.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage((int)damage);
            Destroy(gameObject);
        }

        /*EnemyHealth enemyHealth = collision.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damage);
        }
       if (collision.CompareTag("meleeSwarmer"))
        {
            if (enemyHealth != null)
            {
             enemyHealth.TakeDamage(damage);
            }
            Destroy(gameObject);
        }

       if (collision.CompareTag("rangedSwarmer"))
        {
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }*/
}
