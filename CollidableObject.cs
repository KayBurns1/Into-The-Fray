using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidableObject : MonoBehaviour
{
    private Collider2D Collider;
    private ContactFilter2D Filter;
    private List<Collider2D> CollidedObjectList;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        Collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Collider.OverlapCollider(Filter, CollidedObjectList);
        foreach (var obj in CollidedObjectList)
        {
            WhenCollided(obj.gameObject);
        }
    }

    protected virtual void WhenCollided(GameObject collidedObject)
    {
        Debug.Log("collided with " + collidedObject.name); //probably change to something else later like change scenes
    }
}
