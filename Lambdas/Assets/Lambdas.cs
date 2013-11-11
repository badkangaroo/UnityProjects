using UnityEngine;
using System.Collections;

public class Lambdas : MonoBehaviour {

	// Use this for initialization
	delegate int MyDelegate(int i);
	void Start () {
		MyDelegate myLambda = (x) => x * x; 
		int y = myLambda(5);
		Debug.Log( y );
		
		MyDelegate myDelegate = delegate(int i)
		{
			return i * i;
		};
		int z = myDelegate (5);
		Debug.Log( z );
	}


	
	// Update is called once per frame
	public bool StartCounting;
	public int y = 100000;
	public int a = 0;
	void Update () {
		if( StartCounting ) {
			MyDelegate dt = (x) => ( ++x * y );
			counter = dt(y);
		}
	}
		
	private int counter = 0;
	void OnGUI () {
		GUI.Label(new Rect(10, 10, 100, 20), counter.ToString() );
	}
}
