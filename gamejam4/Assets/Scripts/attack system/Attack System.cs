using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    [SerializeField] private Transform AttackPointBig;
    [SerializeField] private Transform AttackPointMid;
    [SerializeField] private Transform AttackPointSmall;
    
    [SerializeField] private LayerMask enemyLayer; // Layer where enemies reside

    private float AttackRangeS;
    private float AttackRangeM;
    private float AttackRangeB;

    private float lastAttackTime;

    void Start()
    {
        AttackRangeS = (float)Range.Small;
        AttackRangeM = (float)Range.Medium;
        AttackRangeB = (float)Range.Big;
        
        lastAttackTime = -Mathf.Infinity; // Initialize the last attack time
    }

    void Update()
    {
        // a method to detect enemies within range??????
        Collider[] hitEnemies = Physics.OverlapSphere(AttackPointMid.position, AttackRangeM, enemyLayer);

        if (hitEnemies.Length > 0 && Time.time - lastAttackTime > GetCooldown())
        {
            // Attack the enemy within range
            Attack(hitEnemies[0].transform);
            lastAttackTime = Time.time; // Update last attack time
        }
    }

    void Attack(Transform enemy)
    {
        DamageEnemy(enemy);
    }

    void DamageEnemy(Transform enemy)
    {
        Damage weaponDamage = GetComponent<Weapon>().damage;

        if (weaponDamage == Damage.Small)
        {
            // Deal damage 
        }
        else if (weaponDamage == Damage.Medium)
        {
            // Deal damage 
        }
        else if (weaponDamage == Damage.Big)
        {
            // Deal damage 
        }
    }

    float GetCooldown()
    {
        Cooldown weaponCooldown = GetComponent<Weapon>().cooldown;

        if (weaponCooldown == Cooldown.Small)
        {
            return (float)Cooldown.Small;
        }
        else if (weaponCooldown == Cooldown.Medium)
        {
            return (float)Cooldown.Medium;
        }
        else if (weaponCooldown == Cooldown.Big)
        {
            return (float)Cooldown.Big;
        }

        return 0f;
    }
    
    void OnDrawGizmosSelected()
    {
        if (AttackPointMid == null || AttackPointSmall == null || AttackPointMid == null)
            return;
    
        Gizmos.DrawWireSphere(AttackPointMid.position, AttackRangeM);
        Gizmos.DrawWireSphere(AttackPointSmall.position, AttackRangeS);
        Gizmos.DrawWireSphere(AttackPointBig.position, AttackRangeB);
    }
}
