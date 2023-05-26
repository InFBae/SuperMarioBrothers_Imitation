using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelUpMushroom : Item
{
    private void Update()
    {
        Move();
    }

    protected override void Hit()
    {
        // gameObject.Date.Life ++;
        Destroy(gameObject);
    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Hit();
        }
        if (collision.gameObject.tag == "Object")
        {
            Trun();
        }
    }
}
