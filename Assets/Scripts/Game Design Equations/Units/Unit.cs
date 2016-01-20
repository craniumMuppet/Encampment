using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Unit : MonoBehaviour {

    // Use this for initialization
    public  int health;
    public  int damage;
    public  int faith;
    public  int amount;
    public  string unitName;

    void Start()
    {
        Debug.Log(UnitName);
    }

    public string UnitName
    {
        get { return unitName; }
        set { unitName = value; }
    }


    public int Health
    {
        get { return health; }
        set { health = value; }
    }


    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    public int Faith
    {
        get { return faith; }
        set { faith = value; }
    }


}
