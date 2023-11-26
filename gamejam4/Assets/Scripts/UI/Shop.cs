using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{

    
    // buff rate
    private float _buffRate = 1.0f;

    // cost multiplier
    private float _inflationRate = 1f;

    // Costs
    private int _MeleeCost = 1;
    private int _MidRangeCost = 1;
    private int _FarRangeCost = 1;

    private int _HPCost = 1;
    private int _HPRegenCost = 1;
    private int _ArmorCost = 1;
    private int _MovementSpeedCost = 1;
    private int _DamageCost = 1;
    private int _AttackSpeedCost = 1;
    private int _CriticalChanceCost = 1;
    private int _CriticalMultiplayerCost = 1;

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

    [SerializeField] private TMP_Text _HPPricePrompt;
    [SerializeField] private TMP_Text _HPRegenPricePrompt;
    [SerializeField] private TMP_Text _ArmorPricePrompt;
    [SerializeField] private TMP_Text _MovementSpeedPricePrompt;
    [SerializeField] private TMP_Text _DMGPricePrompt;
    [SerializeField] private TMP_Text _AttackSpeedPricePrompt;
    [SerializeField] private TMP_Text _CritChancePricePrompt;
    [SerializeField] private TMP_Text _CritMultipPricePrompt;

    [SerializeField] private TMP_Text _meleePricePrompt;
    [SerializeField] private TMP_Text _MidRangePricePrompt;
    [SerializeField] private TMP_Text _FarRangePricePrompt;

    [SerializeField] private TMP_Text _slimeCounter;
    private int _slimeCount = 0;

    private ShopPricesModifier _shopPrices;

    // Modifiers
    private PlayerStatModifier _modifiersScripts;

    private void Start()
    {
        var temp = GameObject.Find("Modifier");
        _modifiersScripts = temp.GetComponent<PlayerStatModifier>();
        SetCurrentStats();

        _shopPrices = GameObject.Find("ShopPrices").GetComponent<ShopPricesModifier>();

        _MeleeCost = _shopPrices._MeleeCost;
        _MidRangeCost = _shopPrices._MidRangeCost;
        _FarRangeCost = _shopPrices._FarRangeCost;

        _HPCost = _shopPrices._HPCost;
        _HPRegenCost = _shopPrices._HPRegenCost;
        _ArmorCost = _shopPrices._ArmorCost;
        _MovementSpeedCost = _shopPrices._MovementSpeedCost;
        _DamageCost = _shopPrices._DamageCost;
        _AttackSpeedCost = _shopPrices._AttackSpeedCost;
        _CriticalChanceCost = _shopPrices._CriticalChanceCost;
        _CriticalMultiplayerCost = _shopPrices._CriticalMultiplayerCost;

        _inflationRate = _shopPrices._inflationRate;
        _buffRate = _shopPrices._buffRate;

        SetPrices();

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

        _meleeWeaponLevel = _modifiersScripts.MeleeWeaponMod;
        _meleePrompt.text = _meleeWeaponLevel.ToString();

        _MidRangeWeaponLevel = _modifiersScripts.MidWeaponMod;
        _MidRangePrompt.text = _MidRangeWeaponLevel.ToString();

        _FarRangeWeaponLevel = _modifiersScripts.FarWeaponMod;
        _FarRangePrompt.text = _FarRangeWeaponLevel.ToString();

    }

    private void SetPrices()
    {
        _HPPricePrompt.text = _HPCost.ToString();
        _HPRegenPricePrompt.text = _HPRegenCost.ToString();
        _ArmorPricePrompt.text = _ArmorCost.ToString();
        _MovementSpeedPricePrompt.text = _MovementSpeedCost.ToString();
        _DMGPricePrompt.text = _DamageCost.ToString();
        _AttackSpeedPricePrompt.text = _AttackSpeedCost.ToString();
        _CritChancePricePrompt.text = _CriticalChanceCost.ToString();
        _CritMultipPricePrompt.text = _CriticalMultiplayerCost.ToString();

        _meleePricePrompt.text = _MeleeCost.ToString();
        _MidRangePricePrompt.text = _MidRangeCost.ToString();
        _FarRangePricePrompt.text = _FarRangeCost.ToString();

        _shopPrices._MeleeCost = _MeleeCost;
        _shopPrices._MidRangeCost = _MidRangeCost;
        _shopPrices._FarRangeCost = _FarRangeCost;

        _shopPrices._HPCost = _HPCost ;
        _shopPrices._HPRegenCost = _HPRegenCost;
        _shopPrices._ArmorCost = _ArmorCost;
        _shopPrices._MovementSpeedCost = _MovementSpeedCost;
        _shopPrices._DamageCost = _DamageCost;
        _shopPrices._AttackSpeedCost = _AttackSpeedCost;
        _shopPrices._CriticalChanceCost = _CriticalChanceCost;
        _shopPrices._CriticalMultiplayerCost = _CriticalMultiplayerCost;
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
            _HPCost = (int)((float)_HPCost * _inflationRate);
            SetPrices();
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
            _HPRegenCost = (int)((float)_HPRegenCost * _inflationRate);
            SetPrices();
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
            _ArmorCost = (int)((float)_ArmorCost * _inflationRate);
            SetPrices();
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
            _MovementSpeedCost = (int)((float)_MovementSpeedCost * _inflationRate);
            SetPrices();
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
            _DamageCost = (int)((float)_DamageCost * _inflationRate);
            SetPrices();
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
            _AttackSpeedCost = (int)((float)_AttackSpeedCost * _inflationRate);
            SetPrices();
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
            _CriticalChanceCost = (int)((float)_CriticalChanceCost * _inflationRate);
            SetPrices();
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
            _CriticalMultiplayerCost = (int)((float)_CriticalMultiplayerCost * _inflationRate);
            SetPrices();
        }
        
    }

    public void BuffMelee()
    {
        GetCountFromCounter();
        if (_MeleeCost <= _slimeCount)
        {
            _modifiersScripts.MeleeWeaponMod += _buffRate;
            SetCurrentStats();
            _slimeCount -= _MeleeCost;
            RefreshCounter();
            _MeleeCost = (int)((float)_MeleeCost * _inflationRate);
            SetPrices();
        }
        
    }

    public void BuffMidRange()
    {
        GetCountFromCounter();
        if (_MidRangeCost <= _slimeCount)
        {
            _modifiersScripts.MidWeaponMod += _buffRate;
            SetCurrentStats();
            _slimeCount -= _MidRangeCost;
            RefreshCounter();
            _MidRangeCost = (int)((float)_MidRangeCost * _inflationRate);
            SetPrices();
        }
        
    }

    public void BuffFarRange()
    {
        GetCountFromCounter();
        if (_FarRangeCost <= _slimeCount)
        {
            _modifiersScripts.FarWeaponMod += _buffRate;
            SetCurrentStats();
            _slimeCount -= _FarRangeCost;
            RefreshCounter();
            _FarRangeCost = (int)((float)_FarRangeCost * _inflationRate);
            SetPrices();
        }
        
    }
}
