using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //player object
    public GameObject player;
    //how fast enemy moves
    public float speed;
    //distance between player and enemy for enemy to start attacking
    public float distanceBetween;
    //var to keep track of distance between the player and enemy
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //distance between player and enemy
        distance = Vector2.Distance(transform.position, player.transform.position);
        //where the enemy is moving
        Vector2 direction = player.transform.position - transform.position;
        //keep direction but set length to 1
        direction.Normalize();
        //angle for enemy to turn
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //move toward player if the distance between player and enemy is less than distanceBewteen
        if (distance < distanceBetween)
        {
            //move the enemy in this direction
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            //turn the enemy in this direction
            //transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
}
