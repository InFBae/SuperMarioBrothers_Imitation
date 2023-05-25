using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickHit : MonoBehaviour
{
    protected enum State { Small, Big, Flower, Starmen, Death }
    protected  Rigidbody2D rd;
    protected  new Collider2D collider;
    protected  Renderer render;
    protected Animator animator;
    // 블록 맞는 횟수 고려

    [SerializeField] protected GameObject BrickPrebat;
    [SerializeField] protected GameObject ItemPrebat;
    [SerializeField] protected Transform transPoint;


    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        render = GetComponent<Renderer>();
    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("쿵했음");
        }
    }
}
