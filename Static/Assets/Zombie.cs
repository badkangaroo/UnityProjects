using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour
{
	public static int numZombies;
	public bool die;
	public GameObject player;
	public float speed = 0.01f;
	//int numZombies; //no longer static
	// Use this for initialization
	void Start()
	{
		player = GameObject.Find("Main Camera");
		numZombies++;
		Debug.Log(numZombies);
	}
	// Logs number of zombies to the console
	public static void CountZombies()
	{
		Debug.Log(numZombies);
	}

	void Update()
	{
		Vector3 direction = (player.transform.position - transform.position).normalized;
		float distance = (player.transform.position - transform.position).magnitude;
		Vector3 move = transform.position + (direction * speed);
		transform.position = move;
		if (distance < 1f)
		{
			die = true;
		}
		if (die)
		{
			numZombies--;
			Destroy(gameObject);
		}
	}
}
