using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MarioController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float jumpPower;
    [SerializeField] SpriteRenderer render;


    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 direction;

    private bool isGround;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
        animator.SetFloat("moveSpeed", Mathf.Abs(rb.velocity.x));
    }

    private void OnMove(InputValue inputValue)
    {       
        direction = inputValue.Get<Vector2>();        
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

        if((direction.x < 0 && rb.velocity.x > 0) || (direction.x > 0 && rb.velocity.x < 0))
        {
            animator.SetTrigger("DirectionChanged");
        }
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
        if(isGround)
        {
            Jump();
        }        
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("OnGround", true);
        isGround = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("OnGround", false);
        isGround = false;
    }
}
