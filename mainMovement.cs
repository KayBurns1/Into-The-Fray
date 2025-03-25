using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class mainMovemen : MonoBehaviour
{
    //initialize player
    [SerializeField]
    GameObject player;
   
    void Update()
    {
        //move up if w or up arrow is pressed
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 increment = new Vector3(0, 0.01f, 0);
            player.transform.position = player.transform.position + increment;
        }

        //move up if s or down arrow is pressed
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 increment = new Vector3(0, -0.01f, 0);
            player.transform.position = player.transform.position + increment;
        }

        //move up if a or left arrow is pressed
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 increment = new Vector3(-0.01f, 0, 0);
            player.transform.position = player.transform.position + increment;
        }

        //move up if d or right arrow is pressed
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 increment = new Vector3(0.01f, 0, 0);
            player.transform.position = player.transform.position + increment;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
        SceneManager.LoadScene("PauseMenu");
        }
    }
}
