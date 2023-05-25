using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelUpMushroom : Item
{
    private void FixedUpdate()
    {
        Move();
    }

    protected override void Hit()
    {
        // TODO레벨이 코딩되면 넣기
        Destroy(gameObject, 0.1f);
    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Hit();
        }
    }
}
