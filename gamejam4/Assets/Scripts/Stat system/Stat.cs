using System;
using UnityEngine;

[System.Serializable]
public class StatData
{
    public int hp = 100;
    public Sprite hpIcon;

    public int hp_regen = 1;
    public Sprite hpRegenIcon;

    public int armor = 0;
    public Sprite armorIcon;

    public int speed_movement = 3;
    public Sprite speedMovementIcon;

    public int dmg = 1;
    public Sprite dmgIcon;

    public int attack_speed = 1;
    public Sprite attackSpeedIcon;

    public int crit_chance = 20;
    public Sprite critChanceIcon;

    public int crit_multipl = 2;
    public Sprite critMultiplIcon;
    
}

public class Stat : MonoBehaviour
{
    [SerializeField] private Sprite hpIcon;
    [SerializeField] private Sprite hpRegenIcon;
    [SerializeField] private Sprite armorIcon;
    [SerializeField] private Sprite speedMovementIcon;
    [SerializeField] private Sprite dmgIcon;
    [SerializeField] private Sprite attackSpeedIcon;
    [SerializeField] private Sprite critChanceIcon;
    [SerializeField] private Sprite critMultiplIcon;
    
    private StatData statData = new StatData();

    private void Start()
    {
            // Przypisanie ikon
            hpIcon = statData.hpIcon;
            hpRegenIcon = statData.hpRegenIcon;
            armorIcon = statData.armorIcon;
            speedMovementIcon = statData.speedMovementIcon;
            dmgIcon = statData.dmgIcon;
            attackSpeedIcon = statData.attackSpeedIcon;
            critChanceIcon = statData.critChanceIcon;
            critMultiplIcon = statData.critMultiplIcon;
    }
    
}
