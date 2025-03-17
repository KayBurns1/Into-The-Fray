using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidableObject : MonoBehaviour
{
    private Collider2D Collider; //variable for object that is going to be collided with the player/object
    private ContactFilter2D Filter; //variable to control which kind of collision happens
    private List<Collider2D> CollidedObjectList; //list of all objects that collide with the collider
    // Start is called before the first frame update
    protected virtual void Start()
    {
        Collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Collider.OverlapCollider(Filter, CollidedObjectList);
        //go to the WhenCollided function for every object in the list
        foreach (var obj in CollidedObjectList)
        {
            WhenCollided(obj.gameObject);
        }
    }

    //function that occurs when something collides with the collider
    protected virtual void WhenCollided(GameObject collidedObject)
    {
        Debug.Log("collided with " + collidedObject.name); //print out what collided with the object
    }
}
