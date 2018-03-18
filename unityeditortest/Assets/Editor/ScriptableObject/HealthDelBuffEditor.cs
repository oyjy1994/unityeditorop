using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(HealthDelBuff))]
public class HealthDelBuffEditor : Editor 
{
    SerializedProperty valueProperty;
    void OnEnable() 
    {
        valueProperty = serializedObject.FindProperty("value");
    }

    public override void OnInspectorGUI()
    {
        HealthDelBuff buff = target as HealthDelBuff;

        GUILayout.BeginVertical();

        EditorGUILayout.PropertyField(valueProperty, new GUIContent("扣血量"));

        GUILayout.EndVertical();

        serializedObject.ApplyModifiedProperties();
    }
}
