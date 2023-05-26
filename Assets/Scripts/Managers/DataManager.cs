using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{

    public enum State { Small, Big, Flower, Starmen, Death }

    
    [SerializeField] private int life;

    [SerializeField] private int curState;
    public UnityEvent<int> OnCurStateChanged;

    public int Life { get { return life; } set { life = value; } }

    public int CurState
    {
        get { return curState; }
        set
        {
            switch (curState)
            {
                case (int)State.Small:
                    curState = (int)State.Small;
                    OnCurStateChanged?.Invoke(curState);
                    break;
                case (int)State.Big:
                    curState = (int)State.Big;
                    OnCurStateChanged?.Invoke(curState);
                    break;
                case (int)State.Flower:
                    curState = (int)State.Flower;
                    OnCurStateChanged?.Invoke(curState);
                    break;
                case (int)State.Starmen:
                    curState = (int)State.Starmen;
                    OnCurStateChanged?.Invoke(curState);
                    break;
                case (int)State.Death:
                    curState = (int)State.Death;
                    OnCurStateChanged?.Invoke(curState);
                    break;
            }
        }
    }
    [SerializeField] private int curCoin;
    public event UnityAction<int> OnCurCoinChanged;
    public int CurCoin
    {
        get { return curCoin; }
        set
        {
            Debug.Log("11");
            if (curCoin != value)
            {
                OnCurCoinChanged?.Invoke(value);
                curCoin = value;
            }
            if (curCoin >= 100)
            {
                life++;
                curCoin += -100;
            }
        }
    }
}

