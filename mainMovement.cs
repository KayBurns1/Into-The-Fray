using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class mainMovemen : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 increment = new Vector3(0, 0.01f, 0);
            player.transform.position = player.transform.position + increment;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 increment = new Vector3(0, -0.01f, 0);
            player.transform.position = player.transform.position + increment;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 increment = new Vector3(-0.01f, 0, 0);
            player.transform.position = player.transform.position + increment;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 increment = new Vector3(0.01f, 0, 0);
            player.transform.position = player.transform.position + increment;
        }
    }
}
