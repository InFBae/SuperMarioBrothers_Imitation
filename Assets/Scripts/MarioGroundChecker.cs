using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioGroundChecker : MonoBehaviour
{
    [SerializeField] private MarioMoveController parent;
    

    private void Start()
    {
        parent = GetComponentInParent<MarioMoveController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        parent.isGround++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        parent.isGround--;
    }
}
