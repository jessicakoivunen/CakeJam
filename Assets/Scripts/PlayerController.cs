using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Movement
    public float speed = 1.0f;
    public Animator animator;
    private Vector2 movement;
    private Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();

        if (movement.x != 0 || movement.y != 0) { 
            animator.SetFloat("X", movement.x);
            animator.SetFloat("Y", movement.y);

            animator.SetBool("IsWalking", true);
        }
        else {
            animator.SetBool("IsWalking", false);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position +  movement * speed * Time.fixedDeltaTime);
    }
}
