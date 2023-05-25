using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : Item
{
    private void FixedUpdate()
    {
        Move();
    }

    protected override void Hit()
    {
        switch (GameManager.Data.CurState)
        {
            case (int)State.Small:
                GameManager.Data.CurState = (int)State.Big;
                Destroy(gameObject, 0.1f);
                break;
        }
    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Hit();
        }
    }
}
    
