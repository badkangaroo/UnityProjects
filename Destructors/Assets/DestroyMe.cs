using UnityEngine;
using System.Collections;

public class DestroyMe {
	public string name;

	//constructor
	public DestroyMe(string name)
	{
		this.name = name;
		Debug.Log( name + " says hello.");
	}
	
	~DestroyMe()
	{
		Debug.Log( name + " says goodbye.");
	}
	
}
