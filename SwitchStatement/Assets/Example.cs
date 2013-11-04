using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {
	public int i = 1;
	void Start ()
	{
		switch ( i )
		{
		case 0:
			Debug.Log("i is zero");
			break;
				
		case 1:
			Debug.Log("i is one");
			break;	
		
		case 2:
			Debug.Log("i is two");
			break;
		}
	}
}
