using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public float Health;
    public float Mana;
    public int Defense;
    public float CurrentHealth;
    public float DamageIntakeBase;

    public void healthRegen(float value)
    {
        CurrentHealth += value;
    }

    public void manaRegen(float value)
    {
        Mana += value;
    }

    public void TakeDamage(float DmgValue, float defense)
    {
        CurrentHealth -= (DmgValue - defense);
    }

}
