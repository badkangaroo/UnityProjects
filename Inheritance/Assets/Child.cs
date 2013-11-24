using System.Collections;
using UnityEngine;

public class Child : Parent
{
	void Start()
	{
		Debug.Log(SomeInt);
		ParentAbility();
	}

	public void ChildAbility()
	{
		Debug.Log("My parent doesn't get me.");
	}
}
