
using UnityEngine;

public class Chaser : MonoBehaviour
{
    [SerializeField] private Transform target;  // The target object to chase
    [SerializeField] private float moveSpeed = 5f;  // The speed at which the object will move
    private Rigidbody2D _rb;

    private void Awake() {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (target != null)
        {
            
            // Calculate the direction to move towards the target
            Vector2 direction = (target.position - transform.position).normalized;
            _rb.velocity = direction * moveSpeed;
            //_rb.transform.Translate(e);
            
        }
    }
}