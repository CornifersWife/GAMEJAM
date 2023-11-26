using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_projectile : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float lifetime = 1f;
    [SerializeField] public float damage = 3f;
    void Start() {
        StartCoroutine(die());
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "enemy") {
            SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        }
    }

    IEnumerator die() {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
