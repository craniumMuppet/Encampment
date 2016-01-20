using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Unit))]
public class UnitEditor : Editor {


    public override void OnInspectorGUI()
    {

        Unit unit = (Unit)target;

        unit.UnitName = EditorGUILayout.TextField("Name", unit.UnitName);
        unit.Health = EditorGUILayout.IntField("Health", unit.Health);
        unit.Damage = EditorGUILayout.IntField("Damage", unit.Damage);
        unit.Faith = EditorGUILayout.IntField("Faith", unit.Faith);
    }
	


}
