using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioHitChecker : MonoBehaviour
{
    [SerializeField] private MarioStateController parent;

    private void Start()
    {
        parent = GetComponentInParent<MarioStateController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        parent.Hit();
    }
}
