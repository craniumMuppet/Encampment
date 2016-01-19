using UnityEngine;
using System.Collections;

public class HordeAttack : HordeManagerScript
{


    private int hordeStrengthStartOfAttack;

    public bool updateOn = false;

    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isActive && updateOn)
        {

        }

	}

    private void AttackStartSetup()
    {
       

    }

    private int HordeStrengthStartOfAttack
    {
        get { return hordeStrengthStartOfAttack; }
        set { hordeStrengthStartOfAttack = value; }
    }



}
