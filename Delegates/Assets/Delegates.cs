using UnityEngine;
using System.Collections;

public class Delegates : MonoBehaviour {
	delegate int MyDelegate();
	
	// Use this for initialization
	void Start () {
		UseDelegate( GetThree );
	}
	
	int GetThree() {
		return 3;
	}
	
	void UseDelegate( MyDelegate d ) {
		int gotNumber = d();
		Debug.Log( gotNumber );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
}
