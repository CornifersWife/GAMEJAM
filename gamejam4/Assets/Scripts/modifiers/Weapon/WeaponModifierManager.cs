using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WeaponModifierManager : MonoBehaviour
{
    public WeaponModifier modifier;
    
    public void SaveModifierData()
    {
        WeaponModifierData modifierData = new WeaponModifierData
        {
            id = modifier.id,
            name = modifier.name,
            speedMod = modifier.speedMod,
            cooldownMod = modifier.cooldownMod,
            rangeMod = modifier.rangeMod,
            damageMod = modifier.damageMod
        };
        
        string jsonData = JsonUtility.ToJson(modifierData);

        string path = Path.Combine(Application.dataPath, "./Scripts/modifiers/weaponModifiersData.txt");

        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);

            bool modifierExists = false;
            foreach (string line in lines)
            {
                WeaponModifierData existingModifier = JsonUtility.FromJson<WeaponModifierData>(line);
                if (existingModifier.id == modifierData.id)
                {
                    modifierExists = true;
                    Debug.LogWarning("Modifier o nazwie " + modifierData.id + " już istnieje w pliku.");
                    break;
                }
            }

            if (!modifierExists)
            {
                File.AppendAllText(path, "\r\n" + jsonData);
                Debug.Log("Dane zostały zapisane");
            }
        }
        else
        {
            File.WriteAllText(path, jsonData);
            Debug.Log("Nowy plik został utworzony: " + path);
        }
    }

    public void LoadModifierData(int rodzaj)
    {
        string path = Path.Combine(Application.dataPath, "./Scripts/modifiers/weaponModifierData.txt");

        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);

            if (rodzaj >= 0 && rodzaj < lines.Length)
            {
                string jsonData = lines[rodzaj];
                WeaponModifierData modifierData = JsonUtility.FromJson<WeaponModifierData>(jsonData);

                modifier.id = modifierData.id;
                modifier.name = modifierData.name;
                modifier.speedMod = modifierData.speedMod;
                modifier.cooldownMod = modifierData.cooldownMod;
                modifier.rangeMod = modifierData.rangeMod;
                modifier.damageMod = modifierData.damageMod;
            }
            else
            {
                Debug.LogError("Nieprawidłowy indeks rodzaju modifiera: " + rodzaj);
            }
        }
        else
        {
            Debug.LogError("Plik nie istnieje: " + path);
        }
    }
}
