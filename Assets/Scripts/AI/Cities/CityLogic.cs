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
        GUI.Label(new Rect(transform.position.x, transform.position.y, transform.position.x + 100, transform.position.y + 100),
            "Defender Strength: " + DefenderStrength.ToString());
    }
}
