using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WeaponModifierData
{
    public int id;
    public string name;
    public float speedMod;
    public float cooldownMod;
    public float rangeMod;
    public float damageMod;
}

public class WeaponModifier : MonoBehaviour
{
    [SerializeField] internal int id;
    [SerializeField] internal string name;
    [SerializeField] internal float speedMod;
    [SerializeField] internal float cooldownMod;
    [SerializeField] internal float rangeMod;
    [SerializeField] internal float damageMod;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
