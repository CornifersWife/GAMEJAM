using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WeaponModifierData
{
    private float speedMod;
    private float cooldownMod;
    private float rangeMod;
    private float damageMod;
}

public class WeaponModifier : MonoBehaviour
{
    [SerializeField] private float speedMod;
    [SerializeField] private float cooldownMod;
    [SerializeField] private float rangeMod;
    [SerializeField] private float damageMod;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
