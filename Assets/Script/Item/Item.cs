using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    protected enum State { Small, Big, Flower, Starmen, Death }
    protected new Rigidbody2D rd;
    protected new Collider2D collider;
    protected new Renderer render;
    protected Animator animator;
    

    protected virtual void Awake()
    {
        rd = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
        render = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
    }

    protected virtual void Move()
    {
        rd.AddForce(Vector2.right * 2f, ForceMode2D.Force);
    }

    protected virtual void Hit()
    {
        Destroy(gameObject);
    }
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Hit();
        }
    }
}
