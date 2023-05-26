using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DieCollision : MonoBehaviour
{
	// ������ �����̶� �Ӹ� �ݶ��̴�(gameObject)�� ������ Die()ȣ��
	// �ؿ� �͵��� �� ���͵��� ��ũ��Ʈ��
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
