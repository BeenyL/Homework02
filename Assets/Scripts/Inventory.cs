using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Equipment[] CurrentEquipment;
    public PlayerStats stats;

    public void TakeDamage()
    {
        stats.CurrentHealth -= (stats.DamageIntakeBase);
    }

    public void ResetHealth()
    {
        stats.CurrentHealth = stats.Health;
    }
}
