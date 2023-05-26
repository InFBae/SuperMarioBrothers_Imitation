using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBrick : BrickHit
{
    
    [SerializeField] private GameObject ItemPrebat;
    [SerializeField] private Transform ItemTransPoint;

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("미스테리 쿵했음");
            switch (GameManager.Data.CurState)
            {
                case (int)State.Small:
                    Instantiate(BrickPrebat, BrickTransPoint.position, BrickTransPoint.rotation);
                    Instantiate(ItemPrebat, ItemTransPoint.position, ItemTransPoint.rotation);
                    //animator.SetTrigger("IsHit");
                    render.enabled = false;
                    Destroy(gameObject);
                    break;
                case (int)State.Big:
                    Instantiate(BrickPrebat, BrickTransPoint.position, BrickTransPoint.rotation);
                    Instantiate(ItemPrebat, ItemTransPoint.position, ItemTransPoint.rotation);
                    //animator.SetTrigger("IsHit");
                    render.enabled = false;
                    Destroy(gameObject);
                    break;
                case (int)State.Flower:
                    Instantiate(BrickPrebat, BrickTransPoint.position, BrickTransPoint.rotation);
                    Instantiate(ItemPrebat, ItemTransPoint.position, ItemTransPoint.rotation);
                    //animator.SetTrigger("IsHit");
                    render.enabled = false;
                    Destroy(gameObject);
                    break;
                case (int)State.Starmen:
                    Instantiate(BrickPrebat, BrickTransPoint.position, BrickTransPoint.rotation);
                    Instantiate(ItemPrebat, ItemTransPoint.position, ItemTransPoint.rotation);
                    //animator.SetTrigger("IsHit");
                    render.enabled = false;
                    Destroy(gameObject);
                    break;
            }

        }
    }
}
