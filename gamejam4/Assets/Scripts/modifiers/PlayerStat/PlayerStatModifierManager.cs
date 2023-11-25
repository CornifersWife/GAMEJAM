using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerStatModifierManager : MonoBehaviour
{
    public PlayerStatModifier modifier;
   
    public void SaveModifierData()
    {
        PlayerStatModifierData modifierData = new PlayerStatModifierData
        {
            id = modifier.id,
            name = modifier.name,
            timeDuration = modifier.timeDuration,
            speedMovementMod = modifier.speedMovementMod,
            speedAttackMod = modifier.speedAttackMod,
            damageMod = modifier.damageMod,
            HPMod = modifier.HPMod,
            armorMod = modifier.armorMod,
            dodgeMod = modifier.dodgeMod
        };

        string jsonData = JsonUtility.ToJson(modifierData);

        string path = Path.Combine(Application.dataPath, "./Scripts/modifiers/buffsData.txt");

        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);

            bool modifierExists = false;
            foreach (string line in lines)
            {
                PlayerStatModifierData existingModifier = JsonUtility.FromJson<PlayerStatModifierData>(line);
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
       string path = Path.Combine(Application.dataPath, "./Scripts/modifiers/buffsData.txt");

       if (File.Exists(path))
       {
           string[] lines = File.ReadAllLines(path);

           if (rodzaj >= 0 && rodzaj < lines.Length)
           {
               string jsonData = lines[rodzaj];
               PlayerStatModifierData modifierData = JsonUtility.FromJson<PlayerStatModifierData>(jsonData);

               modifier.id = modifierData.id;
               modifier.name = modifierData.name;
               modifier.timeDuration = modifierData.timeDuration;
               modifier.speedMovementMod = modifierData.speedMovementMod;
               modifier.speedAttackMod = modifierData.speedAttackMod;
               modifier.damageMod = modifierData.damageMod;
               modifier.HPMod = modifierData.HPMod;
               modifier.armorMod = modifierData.armorMod;
               modifier.dodgeMod = modifierData.dodgeMod;
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
