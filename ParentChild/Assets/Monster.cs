using UnityEngine;
using System.Collections;

public class Monsters : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}

	class Monster
	{
		public int HitPoints;
		public GameObject gameObject;
		
		public Monster()
		{
			HitPoints = 10;
			gameObject =
				GameObject.CreatePrimitive(PrimitiveType.Capsule);
			Debug.Log("A new monster rises!");
		}
		
		public virtual int TakeDamage(int damage)
		{
			return HitPoints - damage;
		}
	}

	class Zombie : Monster
	{
		public int BrainsEaten = 0;
		
		public Zombie()
		{
			Debug.Log("zombie constructor");
			gameObject.transform.position = new Vector3(1, 0, 0);
		}
		
		public override string ToString()
		{
			return string.Format("[Zombie]");
		}
	}
	
	class Vampire : Monster
	{
		public int BloodSucked = 0;
		public override int TakeDamage(int damage)
		{
			return HitPoints - (damage / 2);
		}
	}


}
