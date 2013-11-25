#define TESTING
using UnityEngine;
using System.Collections;
using System;

public class Directives : MonoBehaviour
{
	#region IMPORTANTFUNC
	void ImportantFunc()
	{
		int j = 10;
		
		#region SPECIFICPART
		//lots of stuff here
		int i = 0;
		while (i < 10)
		{
			//more things...
		}
		#endregion
		
		while (j-- > 0)
		{
			//more things...
		}
	}
	#endregion
	
	// Use this for initialization
	void Start()
	{
		int playerHealth = 100;
#if TESTING
#warning DEBUG is on
		playerHealth = 100000;
#elif UNITY_EDITOR
		playerHealth = 100000;
#endif
		
		if (playerHealth < 0)
		{
			Debug.Log("player has died");
		}
	}
	
	#region OtherStuff
	void ImInTheway()
	{
		//some other stuff
	}
	void MeToo()
	{
		//im not doing anything
	}
	#endregion
	

}
