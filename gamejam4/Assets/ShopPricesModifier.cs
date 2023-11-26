using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPricesModifier : MonoBehaviour
{
    // buff rate
    public float _buffRate = 1.0f;

    // cost multiplier
    public float _inflationRate = 1f;

    // Costs
    public int _MeleeCost = 1;
    public int _MidRangeCost = 1;
    public int _FarRangeCost = 1;

    public int _HPCost = 1;
    public int _HPRegenCost = 1;
    public int _ArmorCost = 1;
    public int _MovementSpeedCost = 1;
    public int _DamageCost = 1;
    public int _AttackSpeedCost = 1;
    public int _CriticalChanceCost = 1;
    public int _CriticalMultiplayerCost = 1;
}
