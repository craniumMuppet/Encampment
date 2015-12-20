using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Unit : MonoBehaviour {

    // Use this for initialization
    protected static int health;
    protected static int damage;
    protected static int faith;
    protected static int amount;

    public static int Health
    {
        get { return health; }
        set { health = value; }
    }


    public static int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    public static int Faith
    {
        get { return faith; }
        set { faith = value; }
    }


}
