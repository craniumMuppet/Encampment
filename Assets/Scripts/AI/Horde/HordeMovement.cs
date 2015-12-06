using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[RequireComponent(typeof(NavMeshAgent))]

public class HordeMovement : HordeManagerScript {

    protected NavMeshAgent agent;
    DateTime seed = new DateTime();
 
    int nextTargetIterator;
    private bool isMoving;

    public bool updateOn = true;
   

	void Start ()
    {

        Agent = this.gameObject.GetComponent<NavMeshAgent>();
 

        NextTargetIterator = 0;


        IsMoving = false;

        SetRandomSeed();
   

    }

	// Update is called once per frame
	void Update ()
    {
        if (updateOn)
        {
            CheckTurn();
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

    private bool HasReachedTarget()
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
                        Debug.Log("Horde " + this.gameObject.name + " has reached target. IsMoving set to: false");
                    IsMoving = false;
                    return true;
                }
            }
        }
        return false;
    }

    private void Movement()
    {
        if (IsMoving)
        {
                Debug.Log("Player has turned, beginning movement. IsMoving: True");
            if (HasReachedTarget())
            {
                StateMachine.HordeState = HordeStateMachine.State.AttackCity;
            }
            else
            {
                MoveToTarget();
            }
        }


       
    }

    private void CheckTurn()
    {
        //checks if the player has turned recently via turnmanager
        if(HasTurned())
        {
            IsMoving = true;
        }
    }
    private NavMeshAgent Agent
    {
        get { return agent; }
        set { agent = value; }
    }


    private bool IsMoving
    {
        get { return isMoving; }
        set { isMoving = value; }
    }
    private int NextTargetIterator
    {
        get { return nextTargetIterator; }
        set { nextTargetIterator = value; }
    }



}
