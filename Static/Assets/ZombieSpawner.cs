using UnityEngine;
using System.Collections;

public class ZombieSpawner : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
	
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Zombie.numZombies < 4)
		{
			GameObject go = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			go.AddComponent(typeof(Zombie));
			go.transform.position = transform.position;
		}
	}
}
