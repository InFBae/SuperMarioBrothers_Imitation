using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public abstract class MonsterBase : MonoBehaviour
{
	// 몬스터의 공통적인 기능 구현

	[SerializeField] protected float moveSpeed;   // 몬스터 이동 속도

	protected SpriteRenderer sr;
	protected Rigidbody2D rb;
	protected Animator anim;

	private void Awake()
	{
		this.rb = GetComponent<Rigidbody2D>();
		this.sr = GetComponent<SpriteRenderer>();
		this.anim = GetComponent<Animator>();	
	}

	public abstract void Move();        // 몬스터 이동
	public abstract void Die();			// 몬스터 죽었을 때
}
