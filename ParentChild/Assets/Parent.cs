using UnityEngine;
using System.Collections;

public class Parent : MonoBehaviour
{
	void Start()
	{
		ParentFunction();
	}
	
	public void ParentFunction()
	{
		print("parent says hello");
		FunctionA();
		FunctionB();
	}
	
	public virtual void FunctionA()
	{
		print("function A says hello");
	}
	
	public void FunctionB()
	{
		print("function B says hello");
	}
}