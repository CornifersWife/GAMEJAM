using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerStatModifierData
{
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
    [SerializeField] private float timeDuration;
    [SerializeField] private float speedMovementMod;
    [SerializeField] private float speedAttackMod;
    [SerializeField] private float damageMod;
    [SerializeField] private float HPMod;
    [SerializeField] private float armorMod;
    [SerializeField] private float dodgeMod;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
