using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonsterBase
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
		if (distance <= 0.3f)
		{
			// TODO : 0.3�� ���� �ӹ���
			patrolIndex = (patrolIndex + 1) % patrolPoints.Length;  // ���� ���� ��ġ�� ��
		}

		if (patrolIndex == 0)
			anim.SetBool("isUp", true);
		else if (patrolIndex == 1)
			anim.SetBool("isUp", false);

		Vector2 dir = (patrolPoints[patrolIndex].position - transform.position).normalized;
		transform.Translate(dir * moveSpeed * Time.deltaTime);
	}

	public override void Die()
	{
	}
}
