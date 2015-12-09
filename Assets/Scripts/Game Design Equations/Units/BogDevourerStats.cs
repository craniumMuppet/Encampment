using UnityEngine;
using System.Collections;

public class BogDevourerStats : MonoBehaviour {


    public int health = 80;
    public int damage = 1;
    int amount = 3000000;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public int Health
    {
        get{ return health; }
        set { health = value; }
    }


    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    public int Amount
    {
        get { return damage; }
        set { damage = value; }
    }
}
