using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Equipment[] CurrentEquipment;
    public PlayerStats stats;

    //core inventory
public void TakeDamage(float value)
    {
        stats.CurrentHealth -= (stats.DamageIntakeBase - value);
    }

    public void ResetHealth()
    {
        stats.CurrentHealth = stats.Health;
    }
}
