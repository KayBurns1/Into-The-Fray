using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D projectileRb;
    public float speed;

    public float projectileLife;
    public float projectileCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        projectileCount = projectileLife;
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

    private void FixedUpdate()
    {
        projectileRb.linearVelocity = new Vector2(speed, projectileRb.linearVelocity.y);
    }
}
