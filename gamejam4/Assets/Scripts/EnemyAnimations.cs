using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimations : MonoBehaviour
{
    private Animator _animator; // enemy animator

    private bool _isAttacking = false;
    private bool _isWalking = true;
    private bool _isDead = false;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    public void Walk() // start walk animation
    {
        if( !_isWalking)
        {
            _animator.SetTrigger("Walk");
            _isAttacking = false;
            _isWalking = true;
            _isDead = false;
        }
        
    }

    public void Attack() // start attack animation
    {
        if (!_isAttacking)
        {
            _animator.SetTrigger("Attack");
            _isAttacking = true;
            _isWalking = false;
            _isDead = false;
        }
        
    }

    public void Die() // start die animation
    {
        if (!_isDead)
        {
            _animator.SetTrigger("Die");
            _isAttacking = false;
            _isWalking = false;
            _isDead = true;
        }
        
    }

    public void Destroy() // destroy game object
    {
        Destroy(gameObject);
    }
}
