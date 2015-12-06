using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurnManagerScript : ManagerParent
{

    private static int currentTurn = 1;
    private static int currentTurnChecked = 1;

    private int turnDelegation = 1;

    private GameObject turnButton;
    private GameObject currentTurnHolder;

    private static bool hasTurnedRecently = false;

    void Start()
    {
        CurrentTurnHolder = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("ResetHasTurnedRecently", 0.0f, 0.01f);

    }

    // Update is called once per frame
    void Update()
    {
        UpdateTurn();
    }

    protected void ResetHasTurnedRecently()
    {
        //resets HasTurnedRecently to false (default state)
        HasTurnedRecently = false;
    }

    private void DelegateTurn()
    {
        if (CurrentTurn != CurrentTurnChecked)
        {
            CurrentTurnChecked = CurrentTurn;


        }
    }

    private void UpdateTurn()
    {
        if (RayCastToObject("TurnButton") && Input.GetMouseButtonUp(LEFT_BUTTON))
        {
            CurrentTurn++;
            HasTurnedRecently = true;
                Debug.Log("Has Turned Recently: True");
        }
    }

    public int CurrentTurn
    {
        get { return currentTurn; }
        set { currentTurn = value; }
    }

    public int CurrentTurnChecked
    {
        get { return currentTurnChecked; }
        set { currentTurnChecked = value; }
    }

    public static bool HasTurnedRecently
    {
        get { return hasTurnedRecently; }
        set { hasTurnedRecently = value; }
    }

    public GameObject TurnButton
    {
        get { return turnButton; }
        set { turnButton = value; }
    }

    public GameObject CurrentTurnHolder
    {
        get { return currentTurnHolder; }
        set { currentTurnHolder = value; }
    }
}
