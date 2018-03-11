using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int m_health;

    public void DeltaHealth(int delta)
    {
        m_health += delta;
    }

    public override string ToString()
    {
        return string.Format("Health value = {0}", m_health);
    }
}
