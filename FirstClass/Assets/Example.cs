using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int a = 1 + 2 - 4 + 7; //a = 6 
		int b = 7 + 4 - 2 + 1; //b = 10

		int c = 5 * 5;
		Debug.Log( c );
		int d = 6 * c ;
		Debug.Log( d );
		int e = d + 3;
		Debug.Log( e );
		int f = 7 + e;
		Debug.Log( f );
		int g = 7 + (6 * (int)Mathf.Pow(5,2) + 3);
		Debug.Log( g );
		var t = GetComponent<Transform>();
		if( t is Transform ) {
			t.localPosition = new Vector3( 1, 0, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
	void MyFunction(){int i=0;while(i<10){print(i);i++;}}
}
