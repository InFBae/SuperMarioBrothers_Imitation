using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    protected enum State { Small, Big, Flower, Starmen, Death }
    protected Rigidbody2D rd;
    protected new Collider2D collider;
    protected Animator animator;

    [SerializeField] protected new float moveSpeed;
    

    protected virtual void Awake()
    {
        rd = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        rd.velocity = new Vector2(transform.right.x * moveSpeed, rd.velocity.y);
    }

    protected virtual void Trun() 
    {
        moveSpeed = -moveSpeed;
    }

    protected virtual void Hit()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Hit();

        }
        if (collision.gameObject.tag == "Object")
        {
            Trun();
        }
    }
}


