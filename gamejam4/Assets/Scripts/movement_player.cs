using UnityEngine;
using UnityEngine.Tilemaps;

public class movement_player : MonoBehaviour {
    private Rigidbody2D body;

    private float horizontal;
    private float vertical;

    [SerializeField] private float runSpeed = 20.0f;

    private Vector2 movement;
    public Animator animator;

    void Awake() {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetKey(KeyCode.H))
        {
            animator.SetTrigger("Hit");
        }

        if (Input.GetKey(KeyCode.G))
        {
            animator.SetTrigger("Die");
        }
    }

    private void FixedUpdate() {
        body.velocity = new Vector2(movement.x * runSpeed, movement.y * runSpeed);
    }
}