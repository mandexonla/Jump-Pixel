using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    private Animator _animator;

    private bool isGrounded;

    private Vector2 moveInput;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(moveInput.x * moveSpeed, rb.velocity.y);
        HandleJump();
        UpdateAnimation();
    }

    public void HandleMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        rb.velocity = moveInput * moveSpeed;
        if (moveInput.x > 0) transform.localScale = new Vector3(1, 1, 1);
        else if (moveInput.x < 0) transform.localScale = new Vector3(-1, 1, 1);
    }

    private void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    }

    private void UpdateAnimation()
    {
        bool isRunning = Mathf.Abs(moveInput.x) > 0.1f;
        bool isJumping = !isGrounded;
        bool isFalling = !isGrounded && rb.velocity.y < -0.1f;
        _animator.SetBool("isRunning", isRunning);
        _animator.SetBool("isJumping", isJumping);
        _animator.SetBool("isFalling", isFalling);
    }
}
