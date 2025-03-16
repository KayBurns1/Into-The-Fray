using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractedObject : CollidableObject
{
    protected override void WhenCollided(GameObject collidedObject)
    {
        if (Input.GetKey(KeyCode.E)){
            if (collidedObject.name == "door")
            {
                SceneManager.LoadScene("Blank");//change blank to scene name
            } else if (collidedObject.name == "drunkard")
            {
                SceneManager.LoadScene("BarFight");
            } else
            {
                Debug.Log("collided with " + collidedObject.name); //probably change to something else later like change scenes
            }
            
        }
    }
}
