using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuffManager : MonoBehaviour
{
    //修改磁盘中的.asset文件也会影响这里
    public HealthAddBuff addBuff;
    public HealthDelBuff delBuff;

	void Start ()
    {
        addBuff = AssetDatabase.LoadAssetAtPath<HealthAddBuff>("Assets/Asset/AddBloodBuff.asset");
        delBuff = AssetDatabase.LoadAssetAtPath<HealthDelBuff>("Assets/Asset/DelBloodBuff.asset");
	}

    void OnGUI() 
    {
        if(GUI.Button(new Rect(0, 0, 100, 100), "Add Blood!"))
        {
            //记录之后的操作，通过ctr+z撤销
            Undo.RecordObject(addBuff, "add Blood Buff");

            addBuff.ApplyBuff(this.gameObject);
            addBuff.value += 1;

            //记录改变到磁盘
            EditorUtility.SetDirty(addBuff);

            DisPlayHealth();
        }

        if(GUI.Button(new Rect(100, 0, 100, 100), "Del Blood!"))
        {
            delBuff.ApplyBuff(this.gameObject);
            DisPlayHealth();
        }
    }

    void DisPlayHealth() 
    {
        Debug.Log(GetComponent<Health>().ToString());
    }
}
