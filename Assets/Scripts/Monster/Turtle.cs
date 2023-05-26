using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonsterBase
{
	[SerializeField] Transform checkPoint;
	[SerializeField] LayerMask groundMask;
	[SerializeField] LayerMask groundMask2;
	Vector2 dir;

	private void Update()
	{
		Move();
		
		if (!IsGroundExist() || IsWall())
		{
			Turn();
		}

		// if (하위자식태그인 DyingPoint가 플레이어 발판과 닿았을 땐)
		//		Die();
	}

	public override void Move()
	{
		if(rb.bodyType == RigidbodyType2D.Dynamic)
			rb.velocity = new Vector2(transform.right.x * -1 * moveSpeed, rb.velocity.y);
	}

	public void Turn()		// 방향 전환
	{
		transform.Rotate(Vector3.up, 180);
	}

	bool IsGroundExist()
	{
		Debug.DrawRay(checkPoint.position, Vector2.down, Color.red);
		return Physics2D.Raycast(checkPoint.position, Vector2.down, 1f, groundMask);
	}
	bool IsWall()
	{
		Debug.DrawRay(checkPoint.position, Vector2.left, Color.red);
		return Physics2D.Raycast(checkPoint.position, Vector2.left, 0.7f, groundMask2);
	}

	public override void Die()
	{
		// 플레이어가 머리를 밟으면 등껍질로 변하고(die 애니메이션 실행) 등껍질을 플레이어가 터치하면 
		// 좌우로 왔다갔다함

		// DyingPoint가 플레이어의 발과 닿으면 죽음
		// Find로 tag로 DyingPoint의 하위자식을 찾음
		anim.SetBool("isDying", true);
		rb.bodyType = RigidbodyType2D.Static;
	}
}
