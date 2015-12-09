using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class HordeStats : HordeManagerScript
{

    protected int hordeStrength;
    private List<GameObject> hordeUnits = new List<GameObject>();


    void Awake()
    {
        hordeUnits = GameObjectArrayToList(GameObject.FindGameObjectsWithTag("HordeUnits"));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public List<GameObject> HordeUnits
    {
        get { return hordeUnits; }
        set { hordeUnits = value; }
    }

    private void InitHordeUnits(int NumberOfUnits, string unit)
    {
        /*
        
        Used to initialize all the units and puts them into the HordeUnits List
        
        Loops through the numbers of units (see constats above) and creates them and then stores them in the hordeUnit list
        */
        for (int i = 0; i < NumberOfUnits; i++)
        {

            GameObject Instance = Instantiate(Resources.Load("Prefabs/Units/" + unit, typeof(GameObject))) as GameObject;
            HordeUnits.Add(Instance);
        }
    }


}


