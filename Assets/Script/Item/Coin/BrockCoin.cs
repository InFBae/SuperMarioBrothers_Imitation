using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class BrockCoin : MonoBehaviour
{
    private void Start()
    {
        Appear();
    }

    protected virtual void Appear()
    {
        GameManager.Data.CurCoin ++;
        Destroy(gameObject, 0.5f);
    }
}