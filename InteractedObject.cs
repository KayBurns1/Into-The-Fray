using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//child of CollidableObject script
public class InteractedObject : CollidableObject
{
    //overrides the WhenCollided function
    protected override void WhenCollided(GameObject collidedObject)
    {
        //what happens when e is pressed near the collider object
        if (Input.GetKey(KeyCode.E)){
            //go to another script when the object is a door (like outside or into the bar)
            if (collidedObject.name == "door")
            {
                SceneManager.LoadScene("Blank");//change blank to scene name
            //loads the bar fight scene if the drunkard is the interactable object
            } else if (collidedObject.name == "drunkard")
            {
                SceneManager.LoadScene("BarFight");
            } else
            //placeholder for any other object
            {
                Debug.Log("collided with " + collidedObject.name); //print out what the name of the object that the object collided with
            }
            
        }
    }
}
