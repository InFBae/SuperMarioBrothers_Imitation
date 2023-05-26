using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalBrick : BrickHit
{
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            {
            Debug.Log("블럭에 쿵했음");
            switch (GameManager.Data.CurState)
            {
                case (int)State.Small:
                    animator.SetTrigger("IsHit");
                    break;
                case (int)State.Big:
                    Instantiate(BrickPrebat, BrickTransPoint.position, BrickTransPoint.rotation);
                    render.enabled = false;
                    Destroy(gameObject, 1);
                    break;
                case (int)State.Flower:
                    Instantiate(BrickPrebat, BrickTransPoint.position, BrickTransPoint.rotation);
                    render.enabled = false;
                    Destroy(gameObject, 1);
                    break;
                case (int)State.Starmen:
                    Instantiate(BrickPrebat, BrickTransPoint.position, BrickTransPoint.rotation);
                    render.enabled = false;
                    Destroy(gameObject, 1);
                    break;
            }

        }
    }
}
