using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceEnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform target;  // The target object to chase
    [SerializeField] private float moveSpeed = 5f;  // The speed at which the object will move
    private Rigidbody2D _rb;
    private CircleCollider2D _range;

    private EnemyAnimations _enemyAnimations; // animations controller script

    private Enemy2Range _rangeScript;
    private ShootProjectile _shootScript;

    [SerializeField] private GameObject _projectilePrefab;

    private bool _inRange = false;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _enemyAnimations = GetComponent<EnemyAnimations>();
        _rangeScript = GetComponent<Enemy2Range>();
        _range = GetComponent<CircleCollider2D>();
        _shootScript = GetComponent<ShootProjectile>();
    }

    void Update()
    {
        _inRange = _rangeScript.InRange();
        Vector2 direction = (target.position - transform.position).normalized;
        if (target != null)
        {
            if (!_inRange)
            {
                _enemyAnimations.Walk();
                // Calculate the direction to move towards the target
                
                _rb.velocity = direction * moveSpeed;
                //_rb.transform.Translate(e);
            }
            else
            {
                _rb.velocity = Vector2.zero;
                _enemyAnimations.Attack();
            }
        }

    }

    


}
