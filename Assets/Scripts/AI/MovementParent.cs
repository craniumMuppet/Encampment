using UnityEngine;
using System.Collections;

public abstract class MovementParent : MonoBehaviour {

    protected NavMeshAgent agent;
    private bool isMoving;
    public bool updateOn = true;

    // Use this for initialization
    void Start ()
    {
        Agent = this.gameObject.GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    protected NavMeshAgent Agent
    {
        get { return agent; }
        set { agent = value; }
    }
}
