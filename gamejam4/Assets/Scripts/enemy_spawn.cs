using System;
using System.Collections;
using UnityEngine;

public class enemy_spawn : MonoBehaviour {

    [SerializeField] private GameObject _child;
    [SerializeField] private Boolean spawn = false; 
    [SerializeField] private float min_spawn_delay = 1.5f;
    [SerializeField] private float spawn_delay_random_max = 0.3f;


    private void OnTriggerEnter2D(Collider2D other) {
        spawn = false;
    }

    private void OnTriggerExit2D(Collider2D other) {
        spawn = true;
    }

    public void Start_spawning(int amount) {
        Debug.Log("1");
        StartCoroutine(Spawn_enemy_Coroutine(amount));
    }

    IEnumerator Spawn_enemy_Coroutine(int amount) {
        Debug.Log("2");
        spawn = true;
        for (var i = 0; i < amount;) {
            var randDelay = UnityEngine.Random.Range(0f, spawn_delay_random_max);
            yield return new WaitForSeconds(min_spawn_delay + randDelay);
            if (spawn) {
                Instantiate(_child, transform.position, transform.rotation);
                i++;
            }
        }
        spawn = false;
    }
}