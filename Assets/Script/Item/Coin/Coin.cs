using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    protected new Collider2D collider;
    protected Animator animator;

    private void Update()
    {
        // 애니메이션 부분
    }

    protected virtual void Awake()
    {
        collider = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
    }

    protected virtual void Hit()
    {
        // GameManager.Data.CurCoinScore ++;
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Hit();
        }
    }
}

