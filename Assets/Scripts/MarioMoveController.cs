using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MarioMoveController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float jumpPower;
    [SerializeField] SpriteRenderer render;


    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 direction;

    public int isGround;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
        animator.SetFloat("moveSpeed",rb.velocity.x);
        CheckIsGround();
    }

    private void OnMove(InputValue inputValue)
    {       
        direction = inputValue.Get<Vector2>();
        animator.SetFloat("MoveDirection", direction.x);
        if (direction.x > 0)
        {
            render.flipX = false;
        }
        else if (direction.x < 0)
        {
            render.flipX = true;
        }
        if (Mathf.Abs(direction.x) > 0)
        {
            animator.SetBool("Moving", true);
        }
        else animator.SetBool("Moving", false);

    }

    private void Move()
    {
        if ( rb.velocity.x < maxSpeed && direction.x > 0)
        {
            rb.AddForce(Vector2.right * direction.x * moveSpeed);
        }
        else if( rb.velocity.x > -maxSpeed && direction.x < 0)
        {
            rb.AddForce(Vector2.right * direction.x * moveSpeed);
        }      
    }

    private void OnJump(InputValue inputValue)
    {
        if(isGround > 0)
        {
            Jump();
        }        
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
    }

    private void CheckIsGround()
    {
        if (isGround > 0) { animator.SetBool("OnGround", true); }
        else { animator.SetBool("OnGround", false); }
    }
}
