using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public enum Speed
{
    Slow = 20,
    Medium = 40,
    Fast = 60
}

public enum Cooldown
{
    Small = 5,
    Medium = 10,
    Big = 20
}

public enum Range
{
    Small = 10,
    Medium = 40,
    Big = 70
}

public enum Damage
{
    Small = 2,
    Medium = 5,
    Big = 10
}

[System.Serializable]
public class WeaponData
{
    public string name;
    public Speed speed;
    public Cooldown cooldown;
    public Range range;
    public Damage damage;
}

public class Weapon : MonoBehaviour
{
    [SerializeField] internal string weaponName;
    [SerializeField] internal Speed speed;
    [SerializeField] internal Cooldown cooldown;
    [SerializeField] internal Range range;
    [SerializeField] internal Damage damage;

    [SerializeField] private WeaponManager WeaponManager;

    void Start()
    {
        WeaponManager = GameObject.Find("7").GetComponent<WeaponManager>();

        if (WeaponManager != null)
        {
            WeaponManager.SaveWeaponData();
            
            WeaponManager.LoadWeaponData(1);
        }
        else
        {
            Debug.LogError("WeaponManageranager nie został znaleziony!");
        }
    }
}

