using UnityEngine;
using System.Collections;
public class Zombie : MonoBehaviour, IThing, IDamage
{
	private string ZombieName;
	private int ZombieHitPoints;
	
	public int HitPoints
	{
		get
		{
			return ZombieHitPoints;
		}
		set
		{
			ZombieHitPoints = value;
		}
	}

	public void TakeDamage(int damage)
	{
		ZombieHitPoints -= damage;
		//zombies take damage from baseball bats
	}
	
	public void HealDamage(int damage)
	{
		return;
		//zombies can’t be healed
	}
	
	public string ThingName
	{
		get
		{
			return ZombieName;
		}
		set
		{
			ZombieName = value;
		}
	}
	
	public void SayHello()
	{
		print("brains");
	}
	
	void Start()
	{
	}
	
	void Update()
	{
	}
}
