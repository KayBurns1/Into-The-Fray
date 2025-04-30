using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // player object
    public GameObject player;
    // how fast enemy moves
    public float speed;
    // distance between player and enemy for enemy to start attacking
    public float distanceBetween;
    // var to keep track of distance between the player and enemy
    public float distance;

    // public variables for animator
    public float distanceToPlayer;
    public int movementDirection; // 0 = north, 1 = south, 2 = east, 3 = west

    // internal tracking
    private Vector2 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        // update distance
        distance = Vector2.Distance(transform.position, player.transform.position);
        distanceToPlayer = distance; // for animator use

        // move toward player if close enough
        if (distance < distanceBetween)
        {
            Vector2 direction = (player.transform.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        }

        // calculate movement direction
        UpdateMovementDirection();

        // update last position
        lastPosition = transform.position;
    }

    void UpdateMovementDirection()
    {
        Vector2 moveDelta = (Vector2)transform.position - lastPosition;

        if (moveDelta.magnitude < 0.001f)
        {
            // Not moving
            return;
        }

        if (Mathf.Abs(moveDelta.x) > Mathf.Abs(moveDelta.y))
        {
            // Moving east or west
            if (moveDelta.x > 0)
            {
                movementDirection = 2; // east
            }
            else
            {
                movementDirection = 3; // west
            }
        }
        else
        {
            // Moving north or south
            if (moveDelta.y > 0)
            {
                movementDirection = 0; // north
            }
            else
            {
                movementDirection = 1; // south
            }
        }
    }
}
