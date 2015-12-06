﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class HordeManagerScript : ManagerParent {

    protected static List<GameObject> hordeTargets = new List<GameObject>();
    protected HordeStateMachine stateMachine;
    protected GameObject target;
    protected int hordeStrength;


    void Awake ()
    {
        
        HordeTargets.AddRange(GameObject.FindGameObjectsWithTag("HordeTarget"));
        StateMachine = this.gameObject.GetComponent<HordeStateMachine>();
            Debug.Log("HordeTargets Count: " + HordeTargets.Count);

        HordeStrength = 10000;



        Target = HordeTargets[0]; //change this later, temp!


    }



    protected bool HasTurned()
    {
        return TurnManagerScript.HasTurnedRecently;
    }
	

    public static List<GameObject> HordeTargets
    {
        get{ return hordeTargets; }
        set { hordeTargets = value; }
    }

    protected HordeStateMachine StateMachine
    {
        get { return stateMachine; }
        set { stateMachine = value; }
    }

    protected GameObject Target
    {
        get { return target; }
        set { target = value; }
    }

    public int HordeStrength
    {
        get { return hordeStrength; }
        set { hordeStrength = value; }
    }


}