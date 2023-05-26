using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class BrockCoin : MonoBehaviour
{
    private void Update()
    {
        Appear();
    }
    protected virtual void Appear()
    {
        GameManager.Data.CurCoin += 1;
        Destroy(gameObject, 0.5f);
    }
}