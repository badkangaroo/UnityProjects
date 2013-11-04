using UnityEngine;
using System.Collections;
using AGameCo.ZGame.Zombie;

namespace AGameCo.ZGame.Damage
{
	public class Damage
	{
		public DamageInfo GetDamage( DamageType dType, int amount )
		{
			DamageInfo damageInfo = new DamageInfo();
			damageInfo.damageType = dType;
			damageInfo.damageAmount = amount;
			DamageInfo DamageInfos = new DamageInfo();
			return damageInfo;
		}
	}
}