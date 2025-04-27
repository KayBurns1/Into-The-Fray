using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalHelper
{
    //function to create a unique id for any object
    public static string GenerateUniqueID(GameObject obj)
    {
        //returns a unique id for the given object
        return $"{obj.scene.name}_{obj.transform.position.x}_{obj.transform.position.y}";
    }
}
