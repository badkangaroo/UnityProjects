using UnityEngine;
using System.Collections;
using AGameCo.ZGame.Damage;

namespace AGameCo.ZGame.Zombie
{
	public partial class Zombie : Behavior
	{
		private int hitPoints = 10;
		
		public void OnTakeDamage(DamageInfo damage)
		{
			hitPoints -= damage.damageAmount;
		}
	}
}