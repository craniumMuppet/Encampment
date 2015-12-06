using UnityEngine;
using System.Collections;

public class HordeStateMachine : MonoBehaviour {

    public enum State
    {
        MoveToCity,
        AttackCity,
        AttackCamp
    }

    private HordeAttack hordeAttack;
    private HordeMovement hordeMovement;

    private State hordeState;
	// Use this for initialization
	void Start ()
    {
        hordeAttack = this.gameObject.GetComponent<HordeAttack>();
        hordeMovement = this.gameObject.GetComponent<HordeMovement>();
        hordeState = State.MoveToCity;

    }
	
	// Update is called once per frame
	void Update ()
    {
        StateManager();
	}

    private void StateManager()
    {
        if(hordeState == State.MoveToCity)
        {
            hordeMovement.updateOn = true;
            hordeAttack.updateOn = false;

        }
        else if (hordeState == State.AttackCity)
        {
            hordeAttack.updateOn = true;
            hordeMovement.updateOn = false;
        }
    }

    public State HordeState
    {
        get { return hordeState; }
        set { hordeState = value; }
    }




}
