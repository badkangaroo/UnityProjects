using UnityEngine;
using System.Collections;

class Zombie
{
	public string Name;
	public int brainsEaten;
	public int hitPoints;
	GameObject ZombieMesh;
	
	public Zombie(string n, int hp)
	{
		Name = n;
		brainsEaten = 0;
		hitPoints = hp;
		ZombieMesh = GameObject.CreatePrimitive(PrimitiveType.Capsule);
		Vector3 pos = new Vector3(
			Random.Range(-10, 10), 0,
			Random.Range(-10, 10));
		ZombieMesh.transform.position = pos;
	}
}
