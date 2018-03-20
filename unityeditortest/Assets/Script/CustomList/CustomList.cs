using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomList : MonoBehaviour {
    [System.Serializable]
    public struct PersonalInfo
    {
        public string name;
        public int age;
    }
    public List<PersonalInfo> m_List = new List<PersonalInfo>();
    //{
    //    new PersonalInfo(){ name = "Tom", age = 14 },
    //    new PersonalInfo(){ name = "Bob", age = 17 },
    //};
}
