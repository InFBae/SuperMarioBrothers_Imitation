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
		// �� �������Ʈ�� ���� �տ� ����� �װ� ���̰ų� ���������� �ݴ�� �̵�
		if (rb.bodyType == RigidbodyType2D.Dynamic)
			rb.velocity = new Vector2(transform.right.x * -moveSpeed, rb.velocity.y);
	}


	public override void Die()
	{
		// �÷��̾ �Ӹ��� ���ڸ��� ��׷�����(Die �ִϸ��̼�) 1�� �ڿ� �����
		rb.bodyType = RigidbodyType2D.Static;
		anim.SetBool("isDying", true);
		Destroy(gameObject, 1.5f);
	}
}
