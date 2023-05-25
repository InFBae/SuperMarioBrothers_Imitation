using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class DataManager : MonoBehaviour
{
    public enum State { Small, Big, Flower, Starmen, Death }
    [SerializeField] private int curState;
    public UnityEvent<int> OnCurStateChanged;

    public GameObject player;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

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

