using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {
	//Declare a nested class	
	class MyClass {
		public int num;
		public void PrintNum() {
			Debug.Log( num );
		}
	}

	// Use this for initialization
	void Start () {
		MyClass FirstClass = new MyClass();
		FirstClass.num = 1;
		MyClass SecondClass = new MyClass();
		SecondClass.num = 2;
		MyClass ThirdClass = new MyClass();
		ThirdClass.num = 3;
		FirstClass.PrintNum();
		SecondClass.PrintNum();
		ThirdClass.PrintNum();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
