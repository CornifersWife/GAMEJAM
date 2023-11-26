using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HPsystemenemy : MonoBehaviour {
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _maxHP = 100f;
    [SerializeField] private float time_of_death = 0.3f;
    [SerializeField] private float contact_damage = 5f;
    private slimy_managment manager = slimy_managment.Instance;

    private void Awake() {
    
            _currentHealth = _maxHP;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Spawner")) {
            _currentHealth -= other.GetComponent<player_projectile>().damage;
            if (_currentHealth <= 0)
                Die();
        }

        if (other.gameObject.CompareTag("Player"))
            _currentHealth -= contact_damage;
        {
            if (_currentHealth <= 0)
                Die();
        }
    }

    private void Die() {
        Destroy(GetComponent<Rigidbody2D>());
        StartCoroutine(CoroutineDie());
        manager.slime += 1;
    }

    IEnumerator CoroutineDie() {
        yield return new WaitForSeconds(time_of_death);
        Destroy(gameObject);
    }
}