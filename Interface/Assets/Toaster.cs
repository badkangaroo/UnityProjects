using UnityEngine;
using System.Collections;

public class Toaster : IThing
{
	private string ToasterName;
	
	public string ThingName
	{
		get
		{
			return ToasterName;
		}
		set
		{
			ToasterName = value;
		}
	}
	
	public void SayHello()
	{
		Debug.Log("howdy doodly do.");
	}
}