using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class WeaponManager : MonoBehaviour
{
    public Weapon weapon;
   
    public void SaveWeaponData()
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

        string path = Path.Combine(Application.dataPath, "./Scripts/attack system/weaponData.txt");

        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);

            bool weaponExists = false;
            foreach (string line in lines)
            {
                WeaponData existingWeapon = JsonUtility.FromJson<WeaponData>(line);
                if (existingWeapon.name == weaponData.name)
                {
                    weaponExists = true;
                    Debug.LogWarning("Broń o nazwie " + weaponData.name + " już istnieje w pliku.");
                    break;
                }
            }

            if (!weaponExists)
            {
                File.AppendAllText(path, "\r\n" + jsonData);
                Debug.Log("Dane broni zostały zapisane");
            }
        }
        else
        {
            File.WriteAllText(path, jsonData);
            Debug.Log("Nowy plik został utworzony: " + path);
        }
    }


   public void LoadWeaponData(int rodzaj)
   {
       string path = Path.Combine(Application.dataPath, "./Scripts/attack system/weaponData.txt");

       if (File.Exists(path))
       {
           string[] lines = File.ReadAllLines(path);

           if (rodzaj >= 0 && rodzaj < lines.Length)
           {
               string jsonData = lines[rodzaj];
               WeaponData weaponData = JsonUtility.FromJson<WeaponData>(jsonData);

               weapon.weaponName = weaponData.name;
               weapon.speed = weaponData.speed;
               weapon.cooldown = weaponData.cooldown;
               weapon.range = weaponData.range;
               weapon.damage = weaponData.damage;
           }
           else
           {
               Debug.LogError("Nieprawidłowy indeks rodzaju broni: " + rodzaj);
           }
       }
       else
       {
           Debug.LogError("Plik nie istnieje: " + path);
       }
   }

}