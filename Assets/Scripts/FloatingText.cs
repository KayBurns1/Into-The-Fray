using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    public Vector2 InitialVelocity;
    public Rigidbody rb;
    public float destroyTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = InitialVelocity;
        Destroy(gameObject, destroyTime);
    }

}
