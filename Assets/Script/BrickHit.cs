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
    private Renderer render;
    [SerializeField] private GameObject brokenBrickPrebat;
    [SerializeField] private Transform brokenPoint;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        render = GetComponent<Renderer>();
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
                    Instantiate(brokenBrickPrebat, brokenPoint.position, brokenPoint.rotation);
                    render.enabled = false;
                    Destroy(gameObject, 1);
                    break;
                case (int)State.Flower:
                    Instantiate(brokenBrickPrebat, brokenPoint.position, brokenPoint.rotation);
                    render.enabled = false;
                    Destroy(gameObject, 1);
                    break;
                case (int)State.Starmen:
                    Instantiate(brokenBrickPrebat, brokenPoint.position, brokenPoint.rotation);
                    render.enabled = false;
                    Destroy(gameObject, 1);
                    break;
            }
            
        }
        

    }
}
