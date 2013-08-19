using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.AddComponent( typeof(BoxCollider) );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
