using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


public abstract class ManagerParent : MonoBehaviour {

    protected Ray               ray;
    protected RaycastHit        hit;
    protected const int         LEFT_BUTTON = 0;
    protected const int         RIGHT_BUTTON = 1;






    protected bool RayCastToObject(string gameObjectTag)
    {

        //checks if the players mouse is over the gameobject and if the tag is equal to the parameter

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag.Equals(gameObjectTag))
            {
                return true;
            }
        }
        return false;
    }
    protected Vector3 RayCastToPosition(string gameObjectTag)
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag.Equals(gameObjectTag))
            {
                return hit.point;
            }
        }
        return new Vector3(0,0,0);
 
    }

    protected static int DateTimeToInt(DateTime date)
    {
        return (int)date.ToBinary();
    }

    protected void SetRandomSeed()
    {
        UnityEngine.Random.seed = DateTimeToInt(DateTime.Now);
        Debug.Log("Seed: " + DateTimeToInt(DateTime.Now));
    }

    public static List<GameObject> GameObjectArrayToList(GameObject[] array)
    {
        //converts an array of gameobjects to a list of gameobjects

        List<GameObject> list = new List<GameObject>();
        list.AddRange(array);
        return list;

    }


}
