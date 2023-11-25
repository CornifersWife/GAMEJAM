using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float _speed = 2f;
    private GameObject _player;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        var player = GameObject.Find("Player_movement");
    }

    private void Start()
    {
        _player = GameObject.Find("Player_movement");
        _rb.velocity = new Vector3(_player.transform.position.x, _player.transform.position.y, 0) * _speed;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
