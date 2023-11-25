using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class WeaponM : MonoBehaviour
{
    public Weapon weapon;

    public void SaveWeaponData(string fileName)
    {
        WeaponData weaponData = new WeaponData
        {
            name = weapon.weaponName,
            speed = weapon.speed,
            cooldown = weapon.cooldown,
            range = weapon.range,
            damage = weapon.damage
        };

        string jsonData = JsonUtility.ToJson(weaponData);

        string path = Path.Combine(Application.persistentDataPath, fileName);
        File.WriteAllText(path, jsonData);
    }

    public void LoadWeaponData(string fileName)
    {
        string path = Path.Combine(Application.persistentDataPath, fileName);

        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            WeaponData weaponData = JsonUtility.FromJson<WeaponData>(jsonData);

            weapon.weaponName = weaponData.name;
            weapon.speed = weaponData.speed;
            weapon.cooldown = weaponData.cooldown;
            weapon.range = weaponData.range;
            weapon.damage = weaponData.damage;
        }
        else
        {
            Debug.LogError("Plik nie istnieje: " + path);
        }
    }
}