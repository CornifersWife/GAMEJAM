using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // weapons levels
    //private float _meleeWeaponLevel = 1f;
    //private float _MidRangeWeaponLevel = 1f;
    //private float _FarRangeWeaponLevel = 1f;

    // stats levels
    private float _HP = 1f;
    //private float _HP_Regen = 1f;
    private float _Armor = 1f;
    private float _Movement_Speed = 1f;
    private float _DMG = 1f;
    private float _Attack_Speed = 1f;
    //private float _Crit_Chance = 1f;
    //private float _Crit_Multip = 1f;

    //text prompts
    [SerializeField] private TMP_Text _meleePrompt;
    [SerializeField] private TMP_Text _MidRangePrompt;
    [SerializeField] private TMP_Text _FarRangePrompt;

    [SerializeField] private TMP_Text _HPPrompt;
    [SerializeField] private TMP_Text _HPRegenPrompt;
    [SerializeField] private TMP_Text _ArmorPrompt;
    [SerializeField] private TMP_Text _MovementSpeedPrompt;
    [SerializeField] private TMP_Text _DMGPrompt;
    [SerializeField] private TMP_Text _AttackSpeedPrompt;
    [SerializeField] private TMP_Text _CritChancePrompt;
    [SerializeField] private TMP_Text _CritMultipPrompt;

    // Modifiers
    private PlayerStatModifier _modifiersScripts;

    private void Awake()
    {
        var temp = GameObject.Find("Modifier");
        _modifiersScripts = temp.GetComponent<PlayerStatModifier>();
        SetCurrentStats();
    }

    void SetCurrentStats()
    {
        _HP = _modifiersScripts.HPMod;
        _HPPrompt.text = _HP.ToString();

        _Armor = _modifiersScripts.armorMod;
        _ArmorPrompt.text = _Armor.ToString();

        _Movement_Speed = _modifiersScripts.speedMovementMod;
        _MovementSpeedPrompt.text = _Movement_Speed.ToString();

        _DMG = _modifiersScripts.damageMod;
        _DMGPrompt.text = _DMG.ToString();

        _Attack_Speed = _modifiersScripts.speedAttackMod;
        _AttackSpeedPrompt.text = _Attack_Speed.ToString();

    }
}
