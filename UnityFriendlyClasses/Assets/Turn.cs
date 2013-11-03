using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour {
	public float direction;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate( new Vector3( 0, direction, 0) );
	}
}
