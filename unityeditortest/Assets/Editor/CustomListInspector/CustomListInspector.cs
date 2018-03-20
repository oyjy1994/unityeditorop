using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

[CanEditMultipleObjects]
[CustomEditor(typeof(CustomList))]
public class CustomListInspector : Editor
{
    ReorderableList orderList;

    void OnEnable() 
    {
        if (null == target)
            return;

        orderList = new ReorderableList(serializedObject, serializedObject.FindProperty("m_List"), true, true, true, true);
        orderList.drawHeaderCallback = rect => 
        {
            EditorGUI.LabelField(new Rect(rect.x, rect.y, 60, rect.height), "名称");
            EditorGUI.LabelField(new Rect(rect.width - 20, rect.y, 60, rect.height), "年龄");
        };
        orderList.drawElementCallback = (rect, index, isActive, isFocused) =>
        {
            var property = orderList.serializedProperty.GetArrayElementAtIndex(index);
            var nameproperty = property.FindPropertyRelative("name");
            var ageproperty = property.FindPropertyRelative("age");

            EditorGUI.PropertyField(new Rect(rect.x, rect.y + 2, 60, EditorGUIUtility.singleLineHeight), nameproperty, GUIContent.none);
            EditorGUI.PropertyField(new Rect(rect.width - 10, rect.y + 2, 40, EditorGUIUtility.singleLineHeight), ageproperty, GUIContent.none);
        };
        orderList.onAddCallback = list => 
        {
            int index = list.serializedProperty.arraySize;
            list.serializedProperty.arraySize++;

            var property = list.serializedProperty.GetArrayElementAtIndex(index);
            property.FindPropertyRelative("name").stringValue = "New Name";
            property.FindPropertyRelative("age").intValue = 0;

            serializedObject.ApplyModifiedProperties();
        };
        orderList.onRemoveCallback = list =>
        {
            ReorderableList.defaultBehaviours.DoRemoveButton(list);

            serializedObject.ApplyModifiedProperties();
        };
    }

    //void 

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        serializedObject.ApplyModifiedProperties();
        serializedObject.Update();

        orderList.DoLayoutList();
        serializedObject.ApplyModifiedProperties();
    }
}
