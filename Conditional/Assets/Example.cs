using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		if (false || false)
		{
			print("I won’t print!");
		}
		
		if (false || false || true)
		{
			print("I will print!");
		}
			      
		if (false || false || false || false || false || false || true)
		{
			print("I will print!"); //just needs one true to work!
		}
		int enemyHealth = 10;
		int myHealth = 1;
		bool imStronger = myHealth > enemyHealth;
		
		int enemyBullets = 0;
		int myBullets = 11;
		bool imArmed = myBullets > enemyBullets;
		
		if (imStronger || imArmed)
		{
			print("I can win!");
		}
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}
}
