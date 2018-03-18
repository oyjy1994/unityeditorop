using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//改动会立即实施到所有地方
abstract public class BaseBuff : ScriptableObject
{
    abstract public void ApplyBuff(GameObject obj);
}
