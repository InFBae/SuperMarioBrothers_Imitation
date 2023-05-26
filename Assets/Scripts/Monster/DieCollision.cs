using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DieCollision : MonoBehaviour
{
	// 마리오 발판이랑 머리 콜라이더(gameObject)랑 닿으면 Die()호출
	// 밑에 것들은 각 몬스터들의 스크립트임
	MonsterBase monster;

	private void Start()
	{
		monster = GetComponentInParent<MonsterBase>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		monster.Die();
	}
}
