using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HeavensRefuge : CityAndHordeManager {


    void Awake()
    {
        UnitTypes = GameObjectArrayToList(GameObject.FindGameObjectsWithTag("CityUnits"));
        UnitAmount = new Dictionary<GameObject, int>() { { FindUnit(UnitTypes, "IronKnight"), 1000 } };
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
