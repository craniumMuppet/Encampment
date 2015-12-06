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
        if (updateOn)
        {
            if (HasTurned())
            {
               Target.GetComponent<CityLogic>().DefenderStrength -= Equations.GetDefenderCasualityFromHordeAttack(this.gameObject);

            }
        }

	}

    private void AttackStartSetup()
    {
        HordeStrengthStartOfAttack = HordeStrength;

    }

    private int HordeStrengthStartOfAttack
    {
        get { return hordeStrengthStartOfAttack; }
        set { hordeStrengthStartOfAttack = value; }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(transform.position.x, transform.position.y + 150, transform.position.x + 100, transform.position.y + 250),
            "Horde Strength: " + HordeStrength.ToString());
    }

}
