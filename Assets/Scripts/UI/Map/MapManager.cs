using UnityEngine;
using System.Collections;

public class MapManager : ManagerParent {

    private GameObject map;
    private bool mapIsActive = false;
    
	

	// Use this for initialization
	void Start () 
	{
        map = GameObject.FindGameObjectWithTag("MapCanvas");
        map.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () 
	{
        ChangeMapActiveState();
        SetActiveMap();
        //CloseMapWhenClickingOutsideBorder();
	}

	private void ChangeMapActiveState()
	{
		//Sets if the map is active or not

		if (Input.GetMouseButtonUp(LEFT_BUTTON) && RayCastToObject("MapTrigger")) 
		{
            MapIsActive = !MapIsActive;
		}
	}

    /*private void CloseMapWhenClickingOutsideBorder()
    {
        //closes the map if the map is active and the player presses outside of the map
        if(MapIsActive && !RayCastToObject("MapCanvas") && !Input.GetMouseButtonUp(LEFT_BUTTON))
        {
            MapIsActive = !MapIsActive;
        }

    }*/

    private void SetActiveMap()
    {
        //sets the map to be inactive of active
        map.SetActive(MapIsActive);
    }

    public bool MapIsActive
    {
        set { mapIsActive = value; }
        get{ return mapIsActive; }
    }

}
