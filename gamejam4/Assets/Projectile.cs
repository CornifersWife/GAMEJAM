using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float _speed = 2f;
    private GameObject _player;
    private float _damage = 1f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        var player = GameObject.Find("Player_movement");
    }

    private void Start()
    {
        _player = GameObject.Find("Player_movement");
        _rb.velocity = (_player.transform.position - transform.position).normalized * _speed;
    }

    public void SetDamage(float damage)
    {
        _damage = damage;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
