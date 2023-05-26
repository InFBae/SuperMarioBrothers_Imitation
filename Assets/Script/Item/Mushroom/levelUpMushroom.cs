using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelUpMushroom : Item
{
    protected override void Hit()
    {
        // gameObject.Date.Life ++;
        Destroy(gameObject);
    }
}
