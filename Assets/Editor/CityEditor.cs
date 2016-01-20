using UnityEngine;
using System.Collections;
using UnityEditor;

public class CityEditor : Editor
{

    public override void OnInspectorGUI()
    {

        City city = (City)target;
        city.CityName = EditorGUILayout.TextField("City name", city.CityName);

    }


}
