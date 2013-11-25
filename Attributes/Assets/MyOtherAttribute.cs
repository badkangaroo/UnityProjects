using System;
using UnityEngine;
using System.Collections;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
public class MyOtherAttribute : Attribute
{
	public string name;
	public string OtherName
	{
		get{ return this.name;}
	}
	
	public int number;
	public int OtherNumber
	{
		get{ return this.number;}
		set{ this.number = value;}
	}

	public MyOtherAttribute(int num)
	{
		this.number = num;
		this.name = num.ToString();
	}
}