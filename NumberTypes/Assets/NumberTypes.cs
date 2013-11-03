using UnityEngine;
using System.Collections;

public class NumberTypes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int a = 1;
		double b = 0.9;
		int c = a * (int)b;
		Debug.Log ( c );
		double d = a;
		Debug.Log( d );
		float f = a;
		Debug.Log( f );
		int largeInt = 214748361;
		Debug.Log( largeInt );
		float largeFloat = largeInt;
		Debug.Log( largeFloat );
		int backAgain = (int)largeFloat;
		Debug.Log( backAgain );
		string s = "1";
		int fromString = int.Parse(s);
		Debug.Log( fromString );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
