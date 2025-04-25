using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D projectileRb;
    public float speed;
    public float projectileLife;
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

  /*  private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("rangedSwarmer") || collision.CompareTag("meleeSwarmer")) // Make sure your enemies are tagged as "Enemy" in the Unity Editor.
        {
            // Optional: damage logic here
            // other.GetComponent<EnemyHealth>().TakeDamage(damageAmount);

            Destroy(gameObject);
        }
    }*/
}
