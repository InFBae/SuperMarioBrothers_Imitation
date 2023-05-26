using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushRoom : MonsterBase
{
	Vector2 dir;

	private void Update()
	{
		Move();
	}

	public override void Move()
	{
		// 그 빈오브젝트를 몬스터 앞에 만들고 그게 벽이거나 낭떠러지면 반대로 이동
		if (rb.bodyType == RigidbodyType2D.Dynamic)
			rb.velocity = new Vector2(transform.right.x * -moveSpeed, rb.velocity.y);
	}


	public override void Die()
	{
		// 플레이어가 머리를 밟자마자 찌그러지고(Die 애니메이션) 1초 뒤에 사라짐
		rb.bodyType = RigidbodyType2D.Static;
		anim.SetBool("isDying", true);
		Destroy(gameObject, 1.5f);
	}
}
