using UnityEngine;
using System.Collections;

public class GetSet : MonoBehaviour {
	private int mInt;
	public int MyInt
	{
		get
		{
			return mInt;
		}
		
		set
		{
			mInt = value;
		}
	}
}
