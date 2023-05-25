using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class DataManager : MonoBehaviour
{
    enum State { Small, Big, Flower, Starmen, Death }
    [SerializeField] private int curState;
    public event UnityAction<int> OnCurStateChanged;

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
                    curState = (int)State.Small;
                    OnCurStateChanged?.Invoke(curState);
                    break;
                case (int)State.Flower:
                    curState = (int)State.Small;
                    OnCurStateChanged?.Invoke(curState);
                    break;
                case (int)State.Starmen:
                    curState = (int)State.Small;
                    OnCurStateChanged?.Invoke(curState);
                    break;
                case (int)State.Death:
                    curState = (int)State.Small;
                    OnCurStateChanged?.Invoke(curState);
                    break;
            }
        }
    }
}

