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

		// if (�����ڽ��±��� DyingPoint�� �÷��̾� ���ǰ� ����� ��)
		//		Die();
	}

	public override void Move()
	{
		if(rb.bodyType == RigidbodyType2D.Dynamic)
			rb.velocity = new Vector2(transform.right.x * -1 * moveSpeed, rb.velocity.y);
	}

	public void Turn()		// ���� ��ȯ
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
		// �÷��̾ �Ӹ��� ������ ����� ���ϰ�(die �ִϸ��̼� ����) ����� �÷��̾ ��ġ�ϸ� 
		// �¿�� �Դٰ�����

		// DyingPoint�� �÷��̾��� �߰� ������ ����
		// Find�� tag�� DyingPoint�� �����ڽ��� ã��
		anim.SetBool("isDying", true);
		rb.bodyType = RigidbodyType2D.Static;
	}
}
