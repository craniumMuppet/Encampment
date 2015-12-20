using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CityStats : CityAndHordeManager {

	// Use this for initialization

	
	// Update is called once per frame
	

    void OnGUI()
    {
        var guiPosition = Camera.main.WorldToScreenPoint(transform.position);
        guiPosition.y = Screen.height - guiPosition.y;
        /*GUI.Label(new Rect(guiPosition.x, guiPosition.y, guiPosition.x+50, guiPosition.y+50),
            this.gameObject.name + " \nDefender Strength: " + DefenderStrength.ToString());*/
    }
}
