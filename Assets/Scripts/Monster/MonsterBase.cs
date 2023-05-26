using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public abstract class MonsterBase : MonoBehaviour
{
	// ������ �������� ��� ����

	[SerializeField] protected float moveSpeed;   // ���� �̵� �ӵ�

	protected SpriteRenderer sr;
	protected Rigidbody2D rb;
	protected Animator anim;

	private void Awake()
	{
		this.rb = GetComponent<Rigidbody2D>();
		this.sr = GetComponent<SpriteRenderer>();
		this.anim = GetComponent<Animator>();	
	}

	public abstract void Move();        // ���� �̵�
	public abstract void Die();			// ���� �׾��� ��
}
