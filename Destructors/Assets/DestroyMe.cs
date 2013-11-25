using UnityEngine;
using System.Collections;

public class DestroyMe
{
	public string name;
	
	//constructor
	public DestroyMe(string name)
	{
		this.name = name;
		Debug.Log(name + " says hello.");
	}
	
	public void OnUpdate()
	{
		Debug.Log(name + " is updating.");
	}
	
	~DestroyMe()
	{
		Debug.Log(name + " says goodbye.");
	}	
}
