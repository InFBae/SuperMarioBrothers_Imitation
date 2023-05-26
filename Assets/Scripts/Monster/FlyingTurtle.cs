using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class FlyingTurtle : MonsterBase
{
	[SerializeField] Transform[] patrolPoints;
	int patrolIndex = 0;
	// float curTime = 2;

	private void Update()
	{
		Move();

		// Time.time > curTime
		/*
		if(Time.time - curTime >= 2f) 
		{
		}*/
	}

	public override void Move()
	{
		float distance = Vector2.Distance(gameObject.transform.position, patrolPoints[patrolIndex].transform.position);
		if(distance <= 0.3f)
		{
			// TODO : 0.3ÃÊ Á¤µµ ¸Ó¹°±â
			patrolIndex = (patrolIndex + 1) % patrolPoints.Length;  // ´ÙÀ½ ¼øÂû À§Ä¡·Î °¨
		}

		Vector2 dir = (patrolPoints[patrolIndex].position - transform.position).normalized;
		transform.Translate(dir * moveSpeed * Time.deltaTime);
	}

	public override void Die()
	{
		// ÇÃ·¹ÀÌ¾î°¡ ¸Ó¸®¸¦ ¹âÀ¸¸é Á×À½
		// ³¯°³¸¦ ¶¼°í ¹ØÀ¸·Î ÈÅ ²¨Áü
		rb.bodyType = RigidbodyType2D.Dynamic;
		anim.SetBool("isDying", true);
	}
}
