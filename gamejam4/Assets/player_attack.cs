using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class player_attack : MonoBehaviour {

    [SerializeField] private float attackdelay = 1f;
    private Vector2 mouse_position;
    [SerializeField] private GameObject projectile;
    private Rigidbody2D rb;
    private float lookat;

    public Camera camera;
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(ShootCoroutine());
    }

    private void Update() {
        mouse_position = camera.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate() {
        Vector2 lookat_ve = mouse_position - rb.position;
        lookat = Mathf.Atan2(lookat_ve.y, lookat_ve.x);
    }

    private IEnumerator ShootCoroutine() {
        while (true) {
            yield return new WaitForSeconds(attackdelay);
            float angle = lookat * Mathf.Rad2Deg - 90f;
            Quaternion rotation = Quaternion.Euler(0, 0, angle);
            Instantiate(projectile, rb.position, rotation);
        }
    }
}
