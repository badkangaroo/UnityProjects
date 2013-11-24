using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	class Zombie
	{
		public int damage = 10;
		public static Zombie operator +(Zombie a, Zombie b)
		{
			Zombie z = new Zombie();
			int powerUp = a.damage + b.damage;
			z.damage = powerUp;
			return z;
		}
		public static bool operator <(Zombie a, Zombie b)
		{
			if (a.damage < b.damage)
			{
				return true;
			} else
			{
				return false;
			}
		}
		public static bool operator >(Zombie a, Zombie b)
		{
			if (a.damage > b.damage)
			{
				return true;
			} else
			{
				return false;
			}
		}
	}

	class Supplies
	{
		public int bandages;
		public int ammunition;
		public float weight;
		
		public Supplies(int size)
		{
			bandages = size;
			ammunition = size * 2;
			weight = bandages * 0.2f + ammunition * 0.7f;
		}
		public static Supplies operator +(Supplies a, Supplies b)
		{
			Supplies s = new Supplies(0);
			int sBandanges = a.bandages + b.bandages;
			int sAmmunition = a.ammunition + b.ammunition;
			float sWeight = a.weight + b.weight;
			s.bandages = sBandanges;
			s.ammunition = sAmmunition;
			s.weight = sWeight;
			return s;
		}
		public static Supplies operator *(Supplies a, int b)
		{
			Supplies s = new Supplies(0);
			int sBandages = a.bandages * b;
			int sAmmunition = a.ammunition * b;
			float sWeight = a.weight * b;
			s.bandages = sBandages;
			s.ammunition = sAmmunition;
			s.weight = sWeight;
			return s;
		}
	}

	void Start()
	{
		Zombie a = new Zombie();
		Zombie b = new Zombie();
		Debug.Log(a.damage);
		Debug.Log(b.damage);
		Zombie c = a + b;
		Debug.Log(c.damage);
		Supplies supplyA = new Supplies(3);
		Supplies supplyB = new Supplies(9);
		Supplies combinedAB = supplyA + supplyB;
		Debug.Log(combinedAB.weight);
		Supplies sm = new Supplies(5);
		Debug.Log(sm.weight);
		sm = sm * 3;
		Debug.Log(sm.weight);
		a.damage = 9;
		if (a < b)
		{
			Debug.Log("a has less damage!");
		}
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}
}
