using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBrick : BrickHit
{
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("미스테리 쿵했음");
            switch (GameManager.Data.CurState)
            {
                case (int)State.Small:
                    Instantiate(BrickPrebat, transPoint.position, transPoint.rotation);
                    Instantiate(ItemPrebat, transPoint.position, transPoint.rotation);
                    //animator.SetTrigger("IsHit");
                    render.enabled = false;
                    Destroy(gameObject, 1);
                    break;
                case (int)State.Big:
                    Instantiate(BrickPrebat, transPoint.position, transPoint.rotation);
                    Instantiate(ItemPrebat, transPoint.position, transPoint.rotation);
                    //animator.SetTrigger("IsHit");
                    render.enabled = false;
                    Destroy(gameObject, 1);
                    break;
                case (int)State.Flower:
                    Instantiate(BrickPrebat, transPoint.position, transPoint.rotation);
                    Instantiate(ItemPrebat, transPoint.position, transPoint.rotation);
                    //animator.SetTrigger("IsHit");
                    render.enabled = false;
                    Destroy(gameObject, 1);
                    break;
                case (int)State.Starmen:
                    Instantiate(BrickPrebat, transPoint.position, transPoint.rotation);
                    Instantiate(ItemPrebat, transPoint.position, transPoint.rotation);
                    //animator.SetTrigger("IsHit");
                    render.enabled = false;
                    Destroy(gameObject, 1);
                    break;
            }

        }
    }
}
