using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;

public class Mushroom : Item
{
    protected override void Hit()
    {
        switch (GameManager.Data.CurState)
        {
            case (int)State.Small:
                GameManager.Data.CurState = (int)State.Big;
                Destroy(gameObject);
                break;
            case (int)State.Big:
                break;
            case (int)State.Flower:
                GameManager.Data.CurState = (int)State.Flower;
                Destroy(gameObject);
                break;
            case (int)State.Starmen:
                GameManager.Data.CurState = (int)State.Starmen;
                Destroy(gameObject);
                break;
        }
    }
}
    
