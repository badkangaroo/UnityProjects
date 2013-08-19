using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int a = 0;
		int b = 1;
		switch ( a )
		{
			case 0:
				a=1;
				FirstFunction( a );
			break;

			case 1:
				SecondFunction();
			break;
		}
	}

	void FirstFunction(int i) {
		switch ( i )
		{
			case 0:
			Debug.Log( "first case");
			break;
			case 1:
			Debug.Log( "i was incremented!");
			break;		}
	}
	
	void SecondFunction() {
		Debug.Log( "second case");
	}
}
