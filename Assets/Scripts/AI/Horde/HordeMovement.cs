using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[RequireComponent(typeof(NavMeshAgent))]

public class HordeMovement : HordeManagerScript {

 
    private int                 nextTargetIterator;
    public bool                 updateOn =  true;
    protected NavMeshAgent      agent;


    void Start ()
    {

        Agent = this.gameObject.GetComponent<NavMeshAgent>();
        NextTargetIterator = 0;
        SetRandomSeed();
   

    }

	// Update is called once per frame
	void Update ()
    {
        if (IsActive && updateOn)
        {
            Movement();   
        }
    }


    private void SetNextTarget()
    {   
        /*
            Sets the next target based on HordeManagerScript HordeTargets
        */
        if(NextTargetIterator > HordeTargets.Count-1)
        {
            NextTargetIterator = 0;
        }
        Target = HordeTargets[NextTargetIterator];
        NextTargetIterator++;
    }

    private void MoveToTarget()
    {
        if(!Agent.pathPending)
        {
            Agent.SetDestination(Target.transform.position);
        }
    }

    public bool HasReachedTarget()
    {
        /*
            Checks if the agent has a path, or if its pending
                Checks if the agent is at the target or close to it
        */
        if(Agent.hasPath && !Agent.pathPending)
        {
            if(Agent.remainingDistance <= Agent.stoppingDistance)
            {
                
                if (!Agent.hasPath || Agent.velocity.sqrMagnitude == 0f)
                {
                        //Debug.Log("Horde " + this.gameObject.name + " has reached target. IsMoving set to: false");
                    return true;
                }
            }
        }
        return false;
    }

    private void Movement()
    {

            //  Debug.Log("HordeMovement - Movement: Horde is moving");
        if (HasReachedTarget())
        {
            StateMachine.HordeState = HordeStateMachine.State.AttackCity;
        }
        else
        {
            MoveToTarget();
        }
    }

    private NavMeshAgent Agent
    {
        get { return agent; }
        set { agent = value; }
    }
    private int NextTargetIterator
    {
        get { return nextTargetIterator; }
        set { nextTargetIterator = value; }
    }
    void OnGUI()
    {

 
        var guiPosition = Camera.main.WorldToScreenPoint(transform.position);
        guiPosition.y = Screen.height - guiPosition.y;
        //GUI.Label(new Rect(guiPosition.x, guiPosition.y, guiPosition.x + 50, guiPosition.y + 50),
            //this.gameObject.name + " \nHorde Strength: " + HordeStrength.ToString());


    }


}
