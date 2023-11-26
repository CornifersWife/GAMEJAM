using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // buff rate
    [SerializeField] private float _buffRate = 1.0f;

    // cost multiplier
    [SerializeField] private float _inflationRate = 1f;

    // Costs
    [SerializeField] private int _MeleeCost = 1;
    [SerializeField] private int _MidRangeCost = 1;
    [SerializeField] private int _FarRangeCost = 1;

    [SerializeField] private int _HPCost = 1;
    [SerializeField] private int _HPRegenCost = 1;
    [SerializeField] private int _ArmorCost = 1;
    [SerializeField] private int _MovementSpeedCost = 1;
    [SerializeField] private int _DamageCost = 1;
    [SerializeField] private int _AttackSpeedCost = 1;
    [SerializeField] private int _CriticalChanceCost = 1;
    [SerializeField] private int _CriticalMultiplayerCost = 1;

    // weapons levels
    private float _meleeWeaponLevel = 1f;
    private float _MidRangeWeaponLevel = 1f;
    private float _FarRangeWeaponLevel = 1f;

    // stats levels
    private float _HP = 1f;
    private float _HP_Regen = 1f;
    private float _Armor = 1f;
    private float _Movement_Speed = 1f;
    private float _DMG = 1f;
    private float _Attack_Speed = 1f;
    private float _Crit_Chance = 1f;
    private float _Crit_Multip = 1f;

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

    [SerializeField] private TMP_Text _slimeCounter;
    private int _slimeCount = 0;

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

        _HP_Regen = _modifiersScripts.HPRegenMod;
        _HPRegenPrompt.text = _HP_Regen.ToString();

        _Crit_Chance = _modifiersScripts.CriticalChanceMod;
        _CritChancePrompt.text = _Crit_Chance.ToString();

        _Crit_Multip = _modifiersScripts.CriticalMultiplierMod;
        _CritMultipPrompt.text = _Crit_Multip.ToString();

        _meleePrompt.text = _meleeWeaponLevel.ToString();
        _MidRangePrompt.text = _MidRangeWeaponLevel.ToString();
        _FarRangePrompt.text = _FarRangeWeaponLevel.ToString();

    }

    private void AddInflation()
    {
        _MeleeCost = (int)((float)_MeleeCost * _inflationRate);
        _MidRangeCost = (int)((float)_MidRangeCost * _inflationRate); ;
        _FarRangeCost = (int)((float)_FarRangeCost * _inflationRate); ;

        _HPCost = (int)((float)_HPCost * _inflationRate); ;
        _HPRegenCost = (int)((float)_HPRegenCost * _inflationRate); ;
        _ArmorCost = (int)((float)_ArmorCost * _inflationRate); ;
        _MovementSpeedCost = (int)((float)_MovementSpeedCost * _inflationRate); ;
        _DamageCost = (int)((float)_DamageCost * _inflationRate); ;
        _AttackSpeedCost = (int)((float)_AttackSpeedCost * _inflationRate); ;
        _CriticalChanceCost = (int)((float)_CriticalChanceCost * _inflationRate); ;
        _CriticalMultiplayerCost = (int)((float)_CriticalMultiplayerCost * _inflationRate); ;
    }

    private void GetCountFromCounter()
    {
        _slimeCount = int.Parse(_slimeCounter.text);
    }
    private void RefreshCounter()
    {
        _slimeCounter.text = _slimeCount.ToString();
    }

    public void BuffHP()
    {
        GetCountFromCounter();
        if(_HPCost <= _slimeCount)
        {
            _modifiersScripts.HPMod += _buffRate;
            SetCurrentStats();
            _slimeCount -= _HPCost;
            RefreshCounter();
            AddInflation();
        }
        
    }
    
    public void BuffHPRegen()
    {
        GetCountFromCounter();
        if(_HPRegenCost <= _slimeCount)
        {
            _modifiersScripts.HPRegenMod += _buffRate;
            SetCurrentStats();
            _slimeCount -= _HPRegenCost;
            RefreshCounter();
            AddInflation();
        }
        
    }

    public void BuffArmor()
    {
        GetCountFromCounter();
        if(_ArmorCost <= _slimeCount)
        {
            _modifiersScripts.armorMod += _buffRate;
            SetCurrentStats();
            _slimeCount -= _ArmorCost;
            RefreshCounter();
            AddInflation();
        }
        
    }

    public void MovementSpeedBuff()
    {
        GetCountFromCounter();
        if (_MovementSpeedCost <= _slimeCount)
        {
            _modifiersScripts.speedMovementMod += _buffRate;
            SetCurrentStats();
            _slimeCount -= _MovementSpeedCost;
            RefreshCounter();
            AddInflation();
        }
        
    }

    public void DamageBuff()
    {
        GetCountFromCounter();
        if (_DamageCost <= _slimeCount)
        {
            _modifiersScripts.damageMod += _buffRate;
            SetCurrentStats();
            _slimeCount -= _DamageCost;
            RefreshCounter();
            AddInflation();
        }
        
    }

    public void AttackSpeedBuff()
    {
        GetCountFromCounter();
        if (_AttackSpeedCost <= _slimeCount)
        {
            _modifiersScripts.speedAttackMod += _buffRate;
            SetCurrentStats();
            _slimeCount -= _AttackSpeedCost;
            RefreshCounter();
            AddInflation();
        }
        
    }

    public void CriticalChanceBuff()
    {
        GetCountFromCounter();
        if (_CriticalChanceCost <= _slimeCount)
        {
            _modifiersScripts.CriticalChanceMod += _buffRate;
            SetCurrentStats();
            _slimeCount -= _CriticalChanceCost;
            RefreshCounter();
            AddInflation();
        }
        
    }

    public void CriticalMultiplierBuff()
    {
        GetCountFromCounter();
        if (_CriticalMultiplayerCost <= _slimeCount)
        {
            _modifiersScripts.CriticalMultiplierMod += _buffRate;
            SetCurrentStats();
            _slimeCount -= _CriticalMultiplayerCost;
            RefreshCounter();
            AddInflation();
        }
        
    }

    public void BuffMelee()
    {
        GetCountFromCounter();
        if (_MeleeCost <= _slimeCount)
        {
            _meleeWeaponLevel += _buffRate;
            SetCurrentStats();
            _slimeCount -= _MeleeCost;
            RefreshCounter();
            AddInflation();
        }
        
    }

    public void BuffMidRange()
    {
        GetCountFromCounter();
        if (_MidRangeCost <= _slimeCount)
        {
            _MidRangeWeaponLevel += _buffRate;
            SetCurrentStats();
            _slimeCount -= _MidRangeCost;
            RefreshCounter();
            AddInflation();
        }
        
    }

    public void BuffFarRange()
    {
        GetCountFromCounter();
        if (_FarRangeCost <= _slimeCount)
        {
            _FarRangeWeaponLevel += _buffRate;
            SetCurrentStats();
            _slimeCount -= _FarRangeCost;
            RefreshCounter();
            AddInflation();
        }
        
    }
}
