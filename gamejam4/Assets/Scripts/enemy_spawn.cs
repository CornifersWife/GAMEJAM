using System;
using System.Collections;
using UnityEngine;

public class enemy_spawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _child;
    [SerializeField] private Boolean spawn= false; //may be used for animating "opening it"
    [SerializeField] private float min_spawn_delay = 1.5f;
    [SerializeField] private int enemies_to_spawn = 5; //used for testing
    [SerializeField] private float spawn_delay_random_max = 0.3f;
    //private Collider2D _c2d;
    private void Awake() {
        //_c2d = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        spawn = false;
    }

    private void OnTriggerExit2D(Collider2D other) {
        spawn = true;
    }

    private void Update() {
        if (spawn) {
            Start_spawning(enemies_to_spawn);
        }
    }

    public void Start_spawning(int amount) {
        var xd =Spawn_enemy_Coroutine(amount);
    }
    IEnumerator Spawn_enemy_Coroutine(int amount) {
        yield return new WaitForSeconds(min_spawn_delay);
        spawn = true;
        for (var i = 0; i < amount;) {
            var randDelay = UnityEngine.Random.Range(0f, spawn_delay_random_max);
            yield return new WaitForSeconds(min_spawn_delay + randDelay);
            //if (spawn) {
            Instantiate(_child, transform.position, transform.rotation);
                i++;
           // }
        }

        spawn = false;
    }
}
