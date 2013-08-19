using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MyDictionary : MonoBehaviour {
	 Dictionary<string,int> dict;
	// Use this for initialization
	void Start () {
		dict = new Dictionary<string,int>();
		dict.Add("Zombies",10);
		Debug.Log ( dict["Zombies"] );
				
		Dictionary<int, Object> obs = new Dictionary<int, Object>();
		Object[] allObjects = GameObject.FindObjectsOfType( typeof( Object ) ) as Object[];
		
		for( int i = 0; i < allObjects.Length; i++ ) {
			obs.Add( i, allObjects[i] );
		}
		Debug.Log( obs[1] );
		Debug.Log( obs[2] );
		Debug.Log( obs[3] );
	}
}
