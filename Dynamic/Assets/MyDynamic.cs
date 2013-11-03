using UnityEngine;
using System.Collections;

public class MyDynamic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var objects = GameObject.FindObjectsOfType( typeof(GameObject) );
		Debug.Log( objects );
		dynamic d = objects;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
