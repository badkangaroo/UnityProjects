using UnityEngine;
using System.Collections;

public class Child : Parent
{
	void Start()
	{
		base.FunctionA();
		ParentFunction();
	}
	
	public override void FunctionA()
	{
		print("Im a new version of function A");
	}
}