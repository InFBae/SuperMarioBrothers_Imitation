using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioStateController : MonoBehaviour
{
    private Rigidbody2D rb;
    private CapsuleCollider2D capsuleCollider;
    private Animator animator;

    private int life;
    private int size;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    private void OnEnable()
    {
        GameManager.Data.OnCurStateChanged.AddListener(ChangeState);
    }

    private void OnDisable()
    {
        GameManager.Data.OnCurStateChanged.RemoveListener(ChangeState);
    }
    public void Hit()
    {
        
    }

    private void ChangeState(int state)
    {
        switch (state)
        {
            case (int)DataManager.State.Small:
                UpdateSmallState();
                break;
            case (int)DataManager.State.Big:
                UpdateBigState();
                break;
        }
    }

    private void UpdateSmallState()
    {
        capsuleCollider.size = (new Vector2(1,1));
        
    }

    private void UpdateBigState()
    {
        
    }
}
