using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MarioStateController : MonoBehaviour
{

    private void OnEnable()
    {
        GameManager.Data.OnCurStateChanged += ChangeState;
    }

    private void OnDisable()
    {
        GameManager.Data.OnCurStateChanged -= ChangeState;
    }

    public UnityAction OnHit;
    public void Hit()
    {
        switch (GameManager.Data.CurState)
        {
            case (int)DataManager.State.Small:
                GameManager.Data.CurState = (int)DataManager.State.Death;
                break;
            case (int)DataManager.State.Big:
                GameManager.Data.CurState = (int)DataManager.State.Small;
                break;
            case (int)DataManager.State.Flower:
                GameManager.Data.CurState = (int)DataManager.State.Big;
                break;
            case (int)DataManager.State.Starmen:
                break;
        }
        
    }

    private void ChangeState(int state)
    {
        switch (state)
        {
            case (int)DataManager.State.Small:
                UpdateSmallState();
                break;
            case (int)DataManager.State.Big:
                UpdateBigState();
                break;
            case (int)DataManager.State.Flower:
                UpdateFlowerState();
                break;
            case (int)DataManager.State.Starmen:
                UpdateStarmenState();
                break;
            case (int)DataManager.State.Death:
                UpdateDeathState();
                break;
        }
    }

    public MarioData marioData;
    private void UpdateSmallState()
    {
        Transform currentPos = this.transform;
        Destroy(this);
        Instantiate(marioData.smallMario, currentPos.transform.position, currentPos.transform.rotation);       
    }

    private void UpdateBigState()
    {
        Transform currentPos = this.transform;
        Destroy(this);
        Instantiate(marioData.bigMario, currentPos.transform.position, currentPos.transform.rotation);
    }

    private void UpdateFlowerState()
    {
        Transform currentPos = this.transform;
        Destroy(this);
        Instantiate(marioData.flowerMario, currentPos.transform.position, currentPos.transform.rotation);
    }

    private void UpdateStarmenState()
    {

    }

    private void UpdateDeathState()
    {
       
    }
}
