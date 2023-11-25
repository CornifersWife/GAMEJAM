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

    private float AttackRange;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    
    void OnDrawGizmosSelected()
    {
        if (AttackPointMid == null || AttackPointMelle == null || AttackPointRanged == null)
            return;
    
        Gizmos.DrawWireSphere(AttackPointMid.position, AttakcRange);
        Gizmos.DrawWireSphere(AttackPointMelle.position, AttakcRange * 1.5f);
        Gizmos.DrawWireSphere(AttackPointRanged.position, AttakcRange);
    }
}
