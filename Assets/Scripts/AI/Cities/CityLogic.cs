using UnityEngine;
using System.Collections;

public class CityLogic : MonoBehaviour {


    private int defenderStrength;
	// Use this for initialization
	void Start ()
    {
        defenderStrength = 10000;
	}
	
	// Update is called once per frame
	
    public int DefenderStrength
    {
        get { return defenderStrength; }
        set { defenderStrength = value; }
    }

    void OnGUI()
    {
        var guiPosition = Camera.main.WorldToScreenPoint(transform.position);
        guiPosition.y = Screen.height - guiPosition.y;
        GUI.Label(new Rect(guiPosition.x, guiPosition.y, guiPosition.x+50, guiPosition.y+50),
            this.gameObject.name + " \nDefender Strength: " + DefenderStrength.ToString());
    }
}
