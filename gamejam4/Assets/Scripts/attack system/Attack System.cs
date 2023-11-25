using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    [SerializeField] private Transform WeaponSlot1;
    [SerializeField] private Transform WeaponSlot2;
    [SerializeField] private Transform WeaponSlot3;
    [SerializeField] private Transform WeaponSlot4;

    [SerializeField] private Transform AttackPointRanged;
    [SerializeField] private Transform AttackPointMid;
    [SerializeField] private Transform AttackPointMelle;

    private float AttackRangeS;
    private float AttackRangeM;
    private float AttackRangeB;

    void Start()
    {
        AttackRangeS = (float)Range.Small;
        AttackRangeM = (float)Range.Medium;
        AttackRangeB = (float)Range.Big;
    }

    
    void Update()
    {
        
    }
    
    void OnDrawGizmosSelected()
    {
        if (AttackPointMid == null || AttackPointMelle == null || AttackPointRanged == null)
            return;
    
        Gizmos.DrawWireSphere(AttackPointMid.position, AttackRangeM);
        Gizmos.DrawWireSphere(AttackPointMelle.position, AttackRangeS);
        Gizmos.DrawWireSphere(AttackPointRanged.position, AttackRangeB);
    }
}
