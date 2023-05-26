using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MarioAttackController : MonoBehaviour
{
    [SerializeField] GameObject attackPoint;
    [SerializeField] GameObject fireBall;
    private void OnAttack(InputValue inputValue)
    {
        Fire();
        if(GameManager.Data.CurState == (int)DataManager.State.Flower)
        {
            Fire();
        }
    }

    private void Fire()
    {
        GameObject shot = Instantiate(fireBall, attackPoint.transform.position, attackPoint.transform.rotation);
        Destroy(shot, 2f);
    }
}
