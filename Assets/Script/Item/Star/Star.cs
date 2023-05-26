using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : Item
{
    private void Start()
    {
        rd.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
    }

    protected override void Hit()
    {
        switch (GameManager.Data.CurState)
        {
            case (int)State.Small:
                GameManager.Data.CurState = (int)State.Starmen;
                Destroy(gameObject);
                break;
            case (int)State.Big:
                GameManager.Data.CurState = (int)State.Starmen;
                Destroy(gameObject);
                break;
            case (int)State.Flower:
                GameManager.Data.CurState = (int)State.Starmen;
                Destroy(gameObject);
                break;
            case (int)State.Starmen:
                Destroy(gameObject);
                break;
        }
    }
}
