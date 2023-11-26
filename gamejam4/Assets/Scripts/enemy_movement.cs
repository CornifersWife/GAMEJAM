using System;
using Unity.VisualScripting;
using UnityEngine;

public class Chaser : MonoBehaviour {
    private GameObject target; // The target object to chase
    [SerializeField] private float moveSpeed = 5f; // The speed at which the object will move
    [SerializeField] private float distance_from_player = 2f;
    private Rigidbody2D _rb;

    private EnemyAnimations _enemyAnimations; // animations controller script

    private void Awake() {
        _rb = GetComponent<Rigidbody2D>();

        target = GameObject.Find("Player_movement");

        _enemyAnimations = GetComponent<EnemyAnimations>();
    }

    void Update() {
        if (target != null) {
            if ((target.transform.position - transform.position).magnitude > distance_from_player) {
                Vector2 direction = (target.transform.position - transform.position).normalized;
                _rb.velocity = direction * moveSpeed;
            }
        }
    }
}