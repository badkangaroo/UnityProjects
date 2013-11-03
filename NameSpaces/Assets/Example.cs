using UnityEngine;
using System.Collections;
using MyNameSpace; //using our new namespace

public class Example : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MyClass mc = new MyClass();
		mc.MyFunction();
		AnotherClassInMyNamespace AnotherClass = new AnotherClassInMyNamespace();
		AnotherClass.MyFunction();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}