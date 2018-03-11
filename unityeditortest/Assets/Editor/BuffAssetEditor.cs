using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BuffAssetEditor : Editor
{
    [MenuItem("CreateBuff/AddBloodBuff")]
    static void CreateAsset1() 
    {
        AssetDatabase.DeleteAsset("Assets/Asset/AddBloodBuff.asset");
        HealthAddBuff buff = ScriptableObject.CreateInstance<HealthAddBuff>();
        if (null == buff)
            return;

        AssetDatabase.CreateAsset(buff, "Assets/Asset/AddBloodBuff.asset");
    }

    [MenuItem("CreateBuff/DelBloodBuff")]
    static void CreateAsset2()
    {
        AssetDatabase.DeleteAsset("Assets/Asset/DelBloodBuff.asset");
        HealthDelBuff buff = ScriptableObject.CreateInstance<HealthDelBuff>();
        if (null == buff)
            return;

        AssetDatabase.CreateAsset(buff, "Assets/Asset/DelBloodBuff.asset");
    }
}
