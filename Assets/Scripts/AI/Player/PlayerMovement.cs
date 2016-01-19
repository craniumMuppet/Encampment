using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[RequireComponent(typeof(NavMeshAgent))]

public class PlayerMovement : PlayerManager
{



    private Vector3             target;
    public static bool          isMoving;
    public bool                 updateOn;
    protected NavMeshAgent      agent;


    void Start()
    {

        Agent =         this.gameObject.GetComponent<NavMeshAgent>();
        IsMoving =      false;
        updateOn =      true;
        SetRandomSeed();


    }
    void Update()
    {
        if (updateOn)
        {
            Movement();
        }
    }

    private void SetNextTarget()
    {

        if (Input.GetMouseButtonUp(LEFT_BUTTON) && RayCastToObject("MapCanvas"))
        {
            Target = RayCastToPosition("MapCanvas");
            IsLineRendererActive(true);
            SetLineRendererCoords();
                Debug.Log("PlayerMovement - SetNextTarget: Setting next targets at coords " + Target);
        }
    }
    

    private void MoveToTarget()
    {
        if (!Agent.pathPending)
        {
            Agent.SetDestination(Target);
        }
    }

    private bool HasReachedTarget()
    {
        /*
            Checks if the agent has a path, or if its pending
                Checks if the agent is at the target or close to it
        */
        if (Agent.hasPath && !Agent.pathPending)
        {
            if (Agent.remainingDistance <= Agent.stoppingDistance)
            {

                if (!Agent.hasPath || Agent.velocity.sqrMagnitude == 0f)
                {
                    Debug.Log(this.gameObject.name + " - Player party has reached target. IsMoving set to: false");
                    return true;
                }
            }
        }
        return false;
    }

    private void Movement()
    {
        StartMovement();
        StopMovement();
        SetNextTarget();
        
            
            if (IsMoving)
            {
                MoveToTarget();
            SetLineRendererCoords();
            }
        

    }

    private void StopMovement()
    {
        //stops the movement if the player presses on the MoveButton again or if the player reaches its target
        if(HasReachedTarget() || (Input.GetMouseButtonUp(LEFT_BUTTON) || Input.GetMouseButtonUp(RIGHT_BUTTON)))
        {
            PlayerMovement.IsMoving = false;
            CityAndHordeManager.isActive = false;
            IsLineRendererActive(false);
            Agent.Stop();
            Debug.Log("StopMovement");
      
        }
    }

    private void StartMovement()
    {
        /*
            Starts the players movement if the player presses on the MoveButton.
            Also activates the hordes and the cities
        */

        if(RayCastToObject("MoveButton") && Input.GetMouseButtonUp(LEFT_BUTTON))
        {
            PlayerMovement.IsMoving = true;
            CityAndHordeManager.isActive = true;
            Input.ResetInputAxes();
            Agent.Resume();
            IsLineRendererActive(true);

        }
    }

    private void IsLineRendererActive(bool isActive)
    {

        this.gameObject.GetComponent<LineRenderer>().enabled = isActive;
        Debug.Log("Linerendered is: " + this.gameObject.GetComponent<LineRenderer>().enabled);
    }
    private void SetLineRendererCoords()
    {
        LineRenderer linerenderer = this.gameObject.GetComponent<LineRenderer>();
        if (linerenderer.enabled == true)
        {
            linerenderer.SetVertexCount(20);
            Vector3[] points = GetLineRenderPositionsInPercentage(20, 0.05f);

            linerenderer.SetPositions(points);
            
        }
    }

    public Vector3[] GetLineRenderPositionsInPercentage(int ArraySize, float FloatIterator)
    {
        /*

            Returns an array of Vector3's. The content of the array is points lerped between the gameobjects current position and the 
            gameobjects target. 

            This function basically takes points in percentage along the vector3 between the gameobjects target and the gameobject 
            and puts those into an array

        */
        Vector3[] points = new Vector3[ArraySize];
        int arrayPosition = 0;
        for (float i = 0; i < 1; i += FloatIterator)
        {
            points[arrayPosition] = new Vector3(
                Vector3.Lerp(this.gameObject.transform.position, Target, i).x,
                Vector3.Lerp(this.gameObject.transform.position, Target, i).y,
                Vector3.Lerp(this.gameObject.transform.position, Target, i).z
                ); 
            arrayPosition++;
        }

        return points;

        
    }
    public static bool IsMoving
    {
        get { return isMoving; }
        set { isMoving = value; }
    }

    private NavMeshAgent Agent
    {
        get { return agent; }
        set { agent = value; }
    }

    protected Vector3 Target
    {
        get { return target; }
        set { target = value; }
    }

  
}
