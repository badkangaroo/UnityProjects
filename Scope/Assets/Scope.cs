using UnityEngine;
using System.Collections;

public class Scope : MonoBehaviour {
	int MyInt = 1;
	
	void Start ()
	{
		Debug.Log( this.MyInt ); //class scope version of MyInt
	
		int MyInt = 3;
	
		Debug.Log( MyInt );
	}

}
