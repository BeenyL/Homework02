using System;
using UnityEngine;

public enum Armor {Helmet, Chestplate, Leggings, Boots }
public enum Rarity { Common, Uncommon, Rare, Epic, Legendary}

//declaration of variables required for each part of the GUI

[Serializable]
public class Equipment
{
    public string name;
    public Armor Type;
    public Rarity RarityType;
    public float defense;
}
[Serializable]
public class PlayerStats
{
    public float Health;
    public float CurrentHealth;
    public float DamageIntakeBase;
}