using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DistanceEnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform target;  // The target object to chase
    [SerializeField] private float moveSpeed = 5f;  // The speed at which the object will move
    [SerializeField] private float cooldown = 8f;
    [SerializeField] private float damage = 10;
    private Rigidbody2D _rb;

    private EnemyAnimations _enemyAnimations; // animations controller script

    private Enemy2Range _rangeScript;

    [SerializeField] private GameObject _projectilePrefab;
    private ShootProjectile _proScript;
    [SerializeField] private GameObject _projectileSpawn;

    private bool _inRange = false;

    private GameObject _trash;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _enemyAnimations = GetComponent<EnemyAnimations>();
        _rangeScript = GetComponent<Enemy2Range>();
        _proScript = GetComponent<ShootProjectile>();

        if (GameObject.Find("Trash"))
        {
            _trash = GameObject.Find("Trash");
        }
        else
        {
            _trash = new GameObject("Trash");
            Instantiate(_trash);
        }
    }

    void Update()
    {
        _inRange = _rangeScript.InRange();
        Debug.Log(_inRange);
        
        if (target != null)
        {
            if (!_inRange)
            {
                _enemyAnimations.Walk();
                // Calculate the direction to move towards the target
                Vector2 direction = (target.position - transform.position).normalized;
                _rb.velocity = direction * moveSpeed;
                //_rb.transform.Translate(e);
            }
            else
            {
                _rb.velocity = Vector2.zero;
            }
        }
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        while (true)
        {
            yield return new WaitForSeconds(cooldown);
            if (_inRange)
            {
                _enemyAnimations.Attack();
            }
        }
        
    }

    public void Shoot()
    {
        var obj = Instantiate(_projectilePrefab, transform.position, transform.rotation,_trash.transform);
        obj.GetComponent<Projectile>().SetDamage(damage);
    }

    


}
