using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class HordeManagerScript : CityAndHordeManager {

    //specific horde stuff not to be used by cities
    protected static List<GameObject> hordeTargets = new List<GameObject>();
    protected HordeStateMachine stateMachine;
    protected GameObject target;




    void Awake ()
    {
        
        HordeTargets.AddRange(GameObject.FindGameObjectsWithTag("HordeTarget"));
        StateMachine = this.gameObject.GetComponent<HordeStateMachine>();
            Debug.Log("HordeTargets Count: " + HordeTargets.Count);


        Target = HordeTargets[0]; //change this later, temp!

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








}
