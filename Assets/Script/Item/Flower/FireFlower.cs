using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFlower : Item
{
    protected override void Hit()
    {
        switch (GameManager.Data.CurState)
        {
            case (int)State.Small:
                GameManager.Data.CurState = (int)State.Flower;
                Destroy(gameObject);
                break;
            case (int)State.Big:
                GameManager.Data.CurState = (int)State.Flower;
                Destroy(gameObject);
                break;
            case (int)State.Flower:
                Destroy(gameObject);
                break;
            case (int)State.Starmen:
                GameManager.Data.CurState = (int)State.Starmen;
                Destroy(gameObject);
                break;
        }
    }

    private void Update()
    {
        // 애니메이션 재생
    }
}
