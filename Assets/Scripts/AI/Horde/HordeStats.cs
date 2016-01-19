using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class HordeStats : HordeManagerScript
{

    protected int hordeStrength;

    void Awake()
    {
        UnitTypes = GameObjectArrayToList(GameObject.FindGameObjectsWithTag("HordeUnits"));
        UnitAmount = new Dictionary<GameObject, int>() { { FindUnit(UnitTypes, "BogDevourer"), 1000 } };
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(UnitAmount[ (FindUnit(UnitTypes, "BogDevourer"))]);


    }






}


