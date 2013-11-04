using UnityEngine;
using System.Collections;
using System;
public class Example : MonoBehaviour {
	DestroyMe dm;

	// Use this for initialization
	void Start () {
		dm = new DestroyMe("rob");
		dm = null;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
