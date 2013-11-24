using UnityEngine;
using System.Collections;

public class ReturnZombie : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		Zombie target = GetZombie();
		if (target != null)
		{
			Debug.DrawLine(transform.position, target.transform.position);
		}
	}


	
	// returns a zombie
	Zombie GetZombie()
	{
		return (Zombie)GameObject.FindObjectOfType(typeof(Zombie));
	}

}
