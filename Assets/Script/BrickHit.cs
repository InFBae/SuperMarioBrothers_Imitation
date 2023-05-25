using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Networking.Types;
using UnityEngine.UI;

public class BrickHit : MonoBehaviour
{
    enum State { Small, Big, Flower, Starmen, Death }
    private bool isHit;
    private int brickHp = 1;
    private Animator animator;
    [SerializeField] private GameObject brokenBrickPrebat;
    [SerializeField] private GameObject mario;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == SortingLayer.GetLayerValueFromName("ItemPlayer"))
        {
            Debug.Log("ÄôÇßÀ½");

            switch (GameManager.Data.CurState)
            {
                case (int)State.Small:
                    animator.SetTrigger("IsHit");
                    break;
                case (int)State.Big:
                    animator.SetTrigger("IsBroken");
                    Destroy(gameObject, 0);
                    break;
                case (int)State.Flower:
                    animator.SetTrigger("IsBroken");
                    Destroy(gameObject, 0);
                    break;
                case (int)State.Starmen:
                    animator.SetTrigger("IsBroken");
                    Destroy(gameObject, 0);
                    break;
            }
            
        }
        

    }
}
