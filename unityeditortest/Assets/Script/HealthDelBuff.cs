using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu] //此属性，可以通过菜单快速添加.asset文件
public class HealthDelBuff : BaseBuff
{
    [SerializeField]
    public int value;
    public override void ApplyBuff(GameObject obj)
    {
        obj.GetComponent<Health>().DeltaHealth(value);
    }
}
