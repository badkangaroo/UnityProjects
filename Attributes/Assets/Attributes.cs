using System;
using UnityEngine;
using System.Collections;

public class Attributes : MonoBehaviour
{
	
	[Serializable]
	public class nestedClass
	{
		public int myInt;
	}
	
	public nestedClass MyNestedClass;
	[NonSerialized]
	public int
		PlainOldInt;
}
