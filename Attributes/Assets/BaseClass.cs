using UnityEngine;
using System.Collections;

public class BaseClass
{
	public string name;
	
	public BaseClass(string n)
	{
		this.name = n;
	}
	
	[MyAttribute("Update")]
	public void OnUpdate()
	{
		Debug.Log(name + " is updating...");
	}
}