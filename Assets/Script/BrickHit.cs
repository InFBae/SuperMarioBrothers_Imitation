using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Networking.Types;
using UnityEngine.UI;

public class BrickHit : MonoBehaviour
{

    private bool isHit;
    private int brickHp = 1;
    private Animator animator;
    [SerializeField] private GameObject brokenBrickPrebat;
    private Coroutine animaRoutine;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == SortingLayer.GetLayerValueFromName("ItemPlayer"))
        {
            /*
            if (collision.transform.DotTest(transform, Vector2.up))
            {
                Hit();
            }
            */
            Debug.Log("ÄôÇßÀ½");
            animator.SetTrigger("IsHit");
        }
        

    }
}
