using System;
using UnityEngine;
using System.Collections;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
public class MyAttribute : Attribute
{
	public string name;
	public string Name
	{
		get{ return this.name;}
	}
	
	public int number;
	public int Number
	{
		get{ return this.number;}
		set{ this.number = value;}
	}

	public MyAttribute(string name)
	{
		this.name = name;
	}
}

public enum MyTypes
{
	Monster,
	Hero,
	NPC
}

[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
public class PlayerType : Attribute
{
	public MyTypes myType;
	public PlayerType(MyTypes mType)
	{
		this.myType = mType;
	}
}