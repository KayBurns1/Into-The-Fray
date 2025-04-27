using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    public Vector2 InitialVelocity; //var to keep track of its initial velocity when falling
    public Rigidbody rb; //var to keep track of rigidbody
    public float destroyTime = 3f; //var to keep track of lifetime of pop up text
    // Start is called before the first frame update
    void Start()
    {
        //initialize the rb velocity
        rb.velocity = InitialVelocity;
        Destroy(gameObject, destroyTime); //destroy the game object after destroy time passes
    }

}
