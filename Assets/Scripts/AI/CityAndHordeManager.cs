using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CityAndHordeManager : ManagerParent {

    private List<GameObject>                    unitTypes = new List<GameObject>(); //the hordeUnitGameobject Templates
    private Dictionary<GameObject, int>         unitAmount; //stores the amount of units in the horde. Keys are the horde units gameobjects (located in hordeUnits)
    public static bool                         isActive = false;





    // Update is called once per frame
    protected GameObject FindUnit(List<GameObject> list, string gameObject)
    {
        //finds a unit in a list and returns it as a gameobject
        //Used to 
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].name.Equals(gameObject))
            {
                return list[i];
            }
        }
        Debug.LogWarning(this.name + " - FindUnit: No Unit found");
        return null;

    }

    public List<GameObject> UnitTypes
    {
        get { return unitTypes; }
        set { unitTypes = value; }
    }

    public Dictionary<GameObject, int> UnitAmount
    {
        get { return unitAmount; }
        set { unitAmount = value; }
    }

    public static bool IsActive
    {
        get { return isActive; }
        set { isActive = value; }
    }

}
