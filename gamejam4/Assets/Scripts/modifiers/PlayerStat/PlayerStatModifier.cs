using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerStatModifierData
{
    public int id;
    public string name;
    public float timeDuration;
    public float speedMovementMod;
    public float speedAttackMod;
    public float damageMod;
    public float HPMod;
    public float armorMod;
    public float dodgeMod;
}

public class PlayerStatModifier : MonoBehaviour
{
    [SerializeField] internal int id;
    [SerializeField] internal string name;
    [SerializeField] internal float timeDuration;
    [SerializeField] internal float speedMovementMod;
    [SerializeField] internal float speedAttackMod;
    [SerializeField] internal float damageMod;
    [SerializeField] internal float HPMod;
    [SerializeField] internal float armorMod;
    [SerializeField] internal float dodgeMod;
    [SerializeField] internal float HPRegenMod;
    [SerializeField] internal float CriticalChanceMod;
    [SerializeField] internal float CriticalMultiplierMod;

    [SerializeField] internal float MeleeWeaponMod;
    [SerializeField] internal float MidWeaponMod;
    [SerializeField] internal float FarWeaponMod;

    [SerializeField] private PlayerStatModifierManager modifierManager;
    
    // Start is called before the first frame update
    void Start()
    {
        modifierManager = GameObject.Find("ModifManager").GetComponent<PlayerStatModifierManager>();

        if (modifierManager != null)
        {
            modifierManager.SaveModifierData();
            
            modifierManager.LoadModifierData(1);
        }
        else
        {
            Debug.LogError("ModifierManager nie został znaleziony!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
