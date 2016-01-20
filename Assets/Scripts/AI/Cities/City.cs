using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class City : CityAndHordeManager {

    public string cityName;

    void Start()
    {
       
    }


    public string CityName
    {
        get { return cityName; }
        set { cityName = value; }
    }



    void OnGUI()
    {
        var guiPosition = Camera.main.WorldToScreenPoint(transform.position);
        guiPosition.y = Screen.height - guiPosition.y;
        /*GUI.Label(new Rect(guiPosition.x, guiPosition.y, guiPosition.x+50, guiPosition.y+50),
            this.gameObject.name + " \nDefender Strength: " + DefenderStrength.ToString());*/
    }
}
