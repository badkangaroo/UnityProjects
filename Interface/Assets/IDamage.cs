using UnityEngine;
using System.Collections;

interface IDamage
{
	int HitPoints { get; set; }
	void TakeDamage(int damage);
	void HealDamage(int damage);
}
