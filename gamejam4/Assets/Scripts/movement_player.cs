using UnityEngine;
using UnityEngine.Tilemaps;

public class movement_player : MonoBehaviour {
    private Rigidbody2D body;

    private float horizontal;
    private float vertical;

    [SerializeField] private float runSpeed = 20.0f;

    void Awake() {
        body = GetComponent<Rigidbody2D>();
    }

    void Update() {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

   
    }

    private void FixedUpdate() {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}