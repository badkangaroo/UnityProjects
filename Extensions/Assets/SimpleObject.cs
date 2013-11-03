using UnityEngine;
using System.Collections;
using Tricks;

public class SimpleObject : Object {
	GameObject gameObject;
	public SimpleObject(GameObject go)
	{
		this.gameObject = go;
		Debug.Log( "im here: " + go.name );
	}
	public void OnUpdate() {
		gameObject.Zero();
	}
	~SimpleObject()
	{
		Debug.Log( "goodbye" );
	}
	
}
