using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrockCoin : MonoBehaviour
{
    private void FixedUpdate()
    {
        Appear();
    }
    protected virtual void Appear()
    {
        // GameManager.Data.CurCoinScore ++;
        Destroy(gameObject, 1);
    }

}
