using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public LayerMask groundLayer;
    private Rigidbody2D rb;
    private bool isGrounded;
    public Animator animator;
    float scale = 0;
    private int jumpCount; // Track the number of jumps

    // Cached references
    private Collider2D collider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
        jumpCount = 0; // Initialize jump count
        scale = transform.localScale.x;
    }

    void Update()
    {
        Move();
        Jump();
        Attack();
        UpdateAnimation();
    }

    private void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        if (moveInput > 0)
        {
            transform.localScale = new Vector3(scale, transform.localScale.y, transform.localScale.z);
        }
        else if (moveInput < 0)
        {
            transform.localScale = new Vector3(-scale, transform.localScale.y, transform.localScale.z);
        }
        Vector2 movement = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        rb.velocity = movement;
    }

    private void Jump()
    {
        isGrounded = Physics2D.IsTouchingLayers(collider, groundLayer);

        if (isGrounded)
        {
            jumpCount = 0; // Reset jump count when grounded
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded || jumpCount < 1) // Allow double jump
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                jumpCount++; // Increment jump count
            }
        }
    }

    private void Attack()
    {
        if (Input.GetButtonDown("Fire1")) // Assuming Fire1 is the attack input
        {
            animator.SetTrigger("isAttacking"); // Trigger attack animation
            // You can add attack logic here (e.g., damage enemies)
        }
    }

    private void UpdateAnimation()
    {
        float speed = Mathf.Abs(rb.velocity.x);
        animator.SetBool("Speed", speed != 0 );
        animator.SetBool("isJumping", !isGrounded); // Set jump animation based on grounded state
    }

}



